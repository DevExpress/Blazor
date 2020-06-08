using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class SalesInfoDataProvider : RemoteDataProviderBase, ISalesInfoDataProvider {
        public Task<IEnumerable<SaleInfo>> GetSalesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetSalesAsync);
        }

        public SalesInfoDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}