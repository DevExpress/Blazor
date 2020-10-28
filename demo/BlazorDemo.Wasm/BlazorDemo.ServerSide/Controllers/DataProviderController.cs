using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.AspNetCoreHost {
    [Route("api/[controller]"), ApiController]
    public class DataProviderController : ControllerBase, IDisposable {
        readonly IDictionary<EntityId, Task<object[]>> _lookup = new Dictionary<EntityId, Task<object[]>>();
        readonly CancellationTokenSource _cts = new CancellationTokenSource();
        readonly CancellationToken _cancellationToken;
        readonly Task _providersReadyToTransfer;

        public DataProviderController(
            ICountryNamesProvider countryNamesProvider,
            IFlatProductsProvider flatProductsProvider,
            IProductCategoriesProvider productCategoriesProvider,
            IProductsProvider productsProvider,
            ISalesInfoDataProvider salesInfoDataProvider,
            ISalesViewerDataProvider salesViewerDataProvider
        ) {
            var ct = _cancellationToken = _cts.Token;

            InitializeEntities(countryNamesProvider, countryNamesProvider.LoadAsync, ct);
            InitializeEntities(flatProductsProvider, flatProductsProvider.LoadAsync, ct);
            InitializeEntities(productCategoriesProvider, productCategoriesProvider.GetProductCategoriesAsync, ct);
            InitializeEntities(productsProvider, productsProvider.LoadAsync, ct);
            InitializeEntities(salesInfoDataProvider, salesInfoDataProvider.GetSalesAsync, ct);

            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetChannels, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetCities, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetContacts, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetCustomers, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetPlants, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetProducts, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetRegions, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetSales, ct);
            InitializeEntities(salesViewerDataProvider, salesViewerDataProvider.GetSectors, ct);

            _providersReadyToTransfer = Task.WhenAll(_lookup.Values);
        }

        void InitializeEntities<TService, TEntity>(TService _, Func<CancellationToken, Task<IEnumerable<TEntity>>> @select, CancellationToken ct)
            where TService : IDataProvider {
            _lookup.Add(EntityId.FromTypes<TService, TEntity>(), WrapEntitiesGetter(@select, ct));
        }

        Task<object[]> WrapEntitiesGetter<TEntity>(Func<CancellationToken, Task<IEnumerable<TEntity>>> select, in CancellationToken ct) {
            return Task.Factory.StartNew(
                function: async (state) => (await select((CancellationToken)state)).Cast<object>().ToArray(),
                state: ct,
                cancellationToken: ct
                ).Unwrap();
        }

        [HttpGet, Route("Metadata")]
        public async IAsyncEnumerable<EntitySetMetadata> Metadata() {
            foreach(var kvp in _lookup) {
                var dataSet = await kvp.Value;
                yield return new EntitySetMetadata(kvp.Key, dataSet.Length);
            }
        }

        [HttpGet, Route("Batch")]
        public async IAsyncEnumerable<object> Batch(Guid provider, Guid entity, int skip, int take) {
            if(_lookup.TryGetValue(new EntityId(provider, entity), out var dataSetTask)) {
                foreach(var item in (await dataSetTask).Skip(skip).Take(take)) {
                    yield return item;
                }
            }
        }

        public void Dispose() {
            try {
                _cts?.Cancel();
                _cts?.Dispose();
            } catch { }
        }
    }
}
