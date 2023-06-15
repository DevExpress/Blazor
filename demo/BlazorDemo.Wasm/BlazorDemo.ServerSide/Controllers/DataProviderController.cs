using System;
using System.Collections.Generic;
using System.Linq;
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
            ISalesInfoDataProvider salesInfoDataProvider,
            IExperimentResultDataProvider experementResultDataProvider,
            INwindDataProvider nwindDataProvider,
            IHomesDataProvider homesDataProvider,
            IIssuesDataProvider issuesDataProvider,
            IWorldcitiesDataProvider worldcitiesDataProvider
        ) {
            var ct = _cancellationToken = _cts.Token;
            InitializeEntities(salesInfoDataProvider, salesInfoDataProvider.GetSalesAsync, ct);
            InitializeEntities(experementResultDataProvider, experementResultDataProvider.GetResultAsync, ct);

            InitializeEntities(nwindDataProvider, nwindDataProvider.GetCategoriesAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetCustomersAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetEmployeesAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetEmployeesEditableAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetInvoicesAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetOrdersAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetOrderDetailsAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetProductsAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetShippersAsync, ct);
            InitializeEntities(nwindDataProvider, nwindDataProvider.GetSuppliersAsync, ct);

            InitializeEntities(homesDataProvider, homesDataProvider.GetHomesAsync, ct);

            InitializeEntities(issuesDataProvider, issuesDataProvider.GetIssuesAsync, ct);
            InitializeEntities(issuesDataProvider, issuesDataProvider.GetProjectsAsync, ct);
            InitializeEntities(issuesDataProvider, issuesDataProvider.GetUsersAsync, ct);

            InitializeEntities(worldcitiesDataProvider, worldcitiesDataProvider.GetCountriesAsync, ct);
            InitializeEntities(worldcitiesDataProvider, worldcitiesDataProvider.GetCitiesAsync, ct);

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
