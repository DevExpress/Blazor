using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class SalesInfoDataProvider : RemoteDataProviderBase, ISalesInfoDataProvider {
        public Task<IEnumerable<SaleInfo>> GetSalesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetSalesAsync);
        }

        public async Task<IEnumerable<SaleInfo>> GetReducedSalesAsync(CancellationToken ct = default) {
            var sales = await GetSalesAsync(ct);
            return sales.Where((el, index) => index % 6 == 0);
        }

        public SalesInfoDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
