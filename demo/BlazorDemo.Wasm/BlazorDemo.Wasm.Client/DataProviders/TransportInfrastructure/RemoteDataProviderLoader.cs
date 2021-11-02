using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace BlazorDemo.Wasm.DataProviders.TransportInfrastructure {
    sealed class RemoteDataProviderLoader {
        private const int FetchBatchSize = 500;

        static readonly Dictionary<Guid, Type> EntityTypeLookup = new Dictionary<Guid, Type>() {
            {typeof(SaleInfo).GUID, typeof(SaleInfo)},
            {typeof(DataPoint).GUID, typeof(DataPoint)},

            {typeof(BlazorDemo.Data.SalesViewer.City).GUID, typeof(BlazorDemo.Data.SalesViewer.City)},
            {typeof(BlazorDemo.Data.SalesViewer.Customer).GUID, typeof(BlazorDemo.Data.SalesViewer.Customer)},
            {typeof(BlazorDemo.Data.SalesViewer.Product).GUID, typeof(BlazorDemo.Data.SalesViewer.Product)},
            {typeof(BlazorDemo.Data.SalesViewer.Sale).GUID, typeof(BlazorDemo.Data.SalesViewer.Sale)},
            {typeof(BlazorDemo.Data.SalesViewer.Channel).GUID, typeof(BlazorDemo.Data.SalesViewer.Channel)},
            {typeof(BlazorDemo.Data.SalesViewer.Contact).GUID, typeof(BlazorDemo.Data.SalesViewer.Contact)},
            {typeof(BlazorDemo.Data.SalesViewer.Plant).GUID, typeof(BlazorDemo.Data.SalesViewer.Plant)},
            {typeof(BlazorDemo.Data.SalesViewer.Region).GUID, typeof(BlazorDemo.Data.SalesViewer.Region)},
            {typeof(BlazorDemo.Data.SalesViewer.Sector).GUID, typeof(BlazorDemo.Data.SalesViewer.Sector)},

            {typeof(BlazorDemo.Data.Northwind.Category).GUID, typeof(BlazorDemo.Data.Northwind.Category)},
            {typeof(BlazorDemo.Data.Northwind.Customer).GUID, typeof(BlazorDemo.Data.Northwind.Customer)},
            {typeof(BlazorDemo.Data.Northwind.Employee).GUID, typeof(BlazorDemo.Data.Northwind.Employee)},
            {typeof(BlazorDemo.Data.Northwind.Invoice).GUID, typeof(BlazorDemo.Data.Northwind.Invoice)},
            {typeof(BlazorDemo.Data.Northwind.Order).GUID, typeof(BlazorDemo.Data.Northwind.Order)},
            {typeof(BlazorDemo.Data.Northwind.OrderDetail).GUID, typeof(BlazorDemo.Data.Northwind.OrderDetail)},
            {typeof(BlazorDemo.Data.Northwind.Product).GUID, typeof(BlazorDemo.Data.Northwind.Product)},
            {typeof(BlazorDemo.Data.Northwind.Supplier).GUID, typeof(BlazorDemo.Data.Northwind.Supplier)},
            {typeof(BlazorDemo.Data.Northwind.Shipper).GUID, typeof(BlazorDemo.Data.Northwind.Shipper)},

            {typeof(BlazorDemo.Data.Northwind.EditableEmployee).GUID, typeof(BlazorDemo.Data.Northwind.EditableEmployee)},

            {typeof(BlazorDemo.Data.Issues.Issue).GUID, typeof(BlazorDemo.Data.Issues.Issue)},
            {typeof(BlazorDemo.Data.Issues.Project).GUID, typeof(BlazorDemo.Data.Issues.Project)},
            {typeof(BlazorDemo.Data.Issues.User).GUID, typeof(BlazorDemo.Data.Issues.User)},

            {typeof(BlazorDemo.Data.Worldcities.Country).GUID, typeof(BlazorDemo.Data.Worldcities.Country)},
            {typeof(BlazorDemo.Data.Worldcities.City).GUID, typeof(BlazorDemo.Data.Worldcities.City)}
        };

        readonly CancellationTokenSource _cts;
        readonly CancellationToken _cancellationToken;
        readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1);
        readonly HttpClient _httpClient;
        readonly IJSRuntime _runtime;
        readonly IServiceProvider _serviceProvider;
        readonly ConcurrentDictionary<Guid, IObservable<int>> _statesLookup;
        readonly ConcurrentDictionary<EntityId, EntityDataContainer> _entityDatasetLookup;

        EntityLoadingState[] _metadataSnapshot;
        static readonly JsonSerializerOptions JSONOptions = new JsonSerializerOptions() {
            PropertyNameCaseInsensitive = true,
            IgnoreReadOnlyProperties = true
        };

        public RemoteDataProviderLoader(HttpClient httpClient, IJSRuntime runtime, IServiceProvider serviceProvider) {
            _cts = new CancellationTokenSource();
            _cancellationToken = _cts.Token;
            _httpClient = httpClient;
            _runtime = runtime;
            _serviceProvider = serviceProvider;
            _statesLookup = new ConcurrentDictionary<Guid, IObservable<int>>();
            _entityDatasetLookup = new ConcurrentDictionary<EntityId, EntityDataContainer>();
        }


        public async Task<IEnumerable<TEntity>> LoadRemoteEntities<TService, TEntity>(TService provider,
            Func<CancellationToken, Task<IEnumerable<TEntity>>> _) where TService : IDataProvider {

            await AssertInvokeUnderProtectedArea(provider);

            return await GetEntityDataContainer(EntityId.FromTypes<TService, TEntity>()).GetData<TEntity>();
        }

        public async Task DeleteEntity<TService, TEntity>(TService provider, TEntity entity)
            where TService : IDataProvider {

            await AssertInvokeUnderProtectedArea(provider);

            await GetEntityDataContainer(EntityId.FromTypes<TService, TEntity>()).Delete(entity);
        }

        public async Task AddEntity<TService, TEntity>(TService provider, TEntity entity)
            where TService : IDataProvider {

            await AssertInvokeUnderProtectedArea(provider);

            await GetEntityDataContainer(EntityId.FromTypes<TService, TEntity>()).Add(entity);
        }

        async ValueTask AssertInvokeUnderProtectedArea<TService>(TService provider) where TService : IDataProvider {
            if(!_statesLookup.TryGetValue(EntityId.GetServiceId(provider.GetType()), out _)) {
                await _runtime.InvokeVoidAsync("alert",
                    _cancellationToken,
                    $"Page should use the @layout DataProviderAccessArea<{EntityId.GetDataProviderContractTypeName(provider.GetType())}>"
                );
            }
        }


        public async Task<IObservable<int>> GetDataProviderStateAsync<T>(T _) where T : IDataProvider {
            await _semaphoreSlim.WaitAsync(_cancellationToken);

            if(_metadataSnapshot == null) {
                var metadataSnapshot = new List<EntityLoadingState>();
                await foreach(var metadata in LoadEntitiesMetadataAsync().WithCancellation(_cancellationToken))
                    metadataSnapshot.Add(metadata);
                _metadataSnapshot = metadataSnapshot.ToArray();
            }

            _semaphoreSlim.Release();

            return _statesLookup.GetOrAdd(EntityId.GetServiceId(_.GetType()), DataProviderLoadingStateFactory);
        }

        IObservable<int> DataProviderLoadingStateFactory(Guid providerId) {
            var result = new DataProviderLoadingState();
            StartProviderLoading(result, GetProviderEntities(providerId));
            return result;
        }

        ReadOnlyMemory<EntityLoadingState> GetProviderEntities(Guid providerId) {
            var start = Array.FindIndex(_metadataSnapshot, Filter);
            var length = _metadataSnapshot.Count(Filter);
            return new ReadOnlyMemory<EntityLoadingState>(_metadataSnapshot, start, length);

            bool Filter(EntityLoadingState x) {
                return x.Entity.Id.Provider == providerId && x.Loaded < x.Entity.Total;
            }
        }

        async void StartProviderLoading(IProgress<int> progress, ReadOnlyMemory<EntityLoadingState> entities) {
            await FetchRequiredDataAsync(DataProviderProgression.Create(progress, entities));
        }



        async Task FetchRequiredDataAsync(DataProviderProgression progression) {
            if(progression.HasMissingData()) {
                EntityLoadingState entityState = progression.RemainingEntities.Span[0];
                int offset = entityState.Loaded;
                var entityDataContainer = GetEntityDataContainer(entityState.Entity.Id);

                var batchArray = await GetBatchAsync(entityState, offset);

                while(batchArray.Length > 0 && offset < entityState.Entity.Total) {
                    entityDataContainer.Append(batchArray);
                    offset += batchArray.Length;
                    progression = progression.Update(batchArray.Length);

                    batchArray = await GetBatchAsync(entityState, offset);
                }
                entityDataContainer.CompleteLoading();

                await FetchRequiredDataAsync(progression.StartNextEntity());
            }
        }
        async IAsyncEnumerable<EntityLoadingState> LoadEntitiesMetadataAsync() {
            await using var stream = await GetAllMetadataAsync().ConfigureAwait(false);
            foreach(var metadata in await DeserializeCollectionAsync<EntitySetMetadata>(stream))
                yield return EntityLoadingState.FromMetadata(metadata);
        }

        async Task<Stream> GetAllMetadataAsync() {
            return await _httpClient
                .GetStreamAsync("api/dataprovider/metadata")
                .ConfigureAwait(false);
        }

        async Task<object[]> GetBatchAsync(EntityLoadingState state, int offset) {
            var result = await _httpClient
                .GetStreamAsync(
                    $"api/dataprovider/batch?provider={state.Entity.Id.Provider}&entity={state.Entity.Id.Entity}&skip={offset}&take={FetchBatchSize}"
                )
                .ConfigureAwait(false);

            var collection = await System.Text.Json.JsonSerializer.DeserializeAsync(result, GetEntityArrayType(state), JSONOptions);
            return ((Array)collection).Cast<object>().ToArray();
        }

        static Type GetEntityArrayType(EntityLoadingState state) {
            Type entityType = EntityTypeLookup.GetValueOrDefault(state.Entity.Id.Entity);
            if(entityType == null)
                entityType = typeof(string);
            return entityType.MakeArrayType();
        }

        async Task<IEnumerable<T>> DeserializeCollectionAsync<T>(Stream stream) {
            using var sr = new StreamReader(stream);
            var json = await sr.ReadToEndAsync();
            return JsonConvert.DeserializeObject<IEnumerable<T>>(json);
        }

        EntityDataContainer GetEntityDataContainer(EntityId id) {
            return _entityDatasetLookup.GetOrAdd(id, CreateDataContainer);
        }
        EntityDataContainer CreateDataContainer(EntityId id) {
            return _serviceProvider.GetService<EntityDataContainer>();
        }
    }
}
