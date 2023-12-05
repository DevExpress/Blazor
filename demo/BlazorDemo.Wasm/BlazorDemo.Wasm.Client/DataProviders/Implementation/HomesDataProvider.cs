using BlazorDemo.Data.Homes;
using BlazorDemo.DataProviders;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;
using System.Reflection;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class HomesDataProvider : RemoteDataProviderBase, IHomesDataProvider {

        public Task<IEnumerable<Home>> GetHomesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetHomesAsync);
        }
        public Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetCustomersAsync);
        }
        public Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetOrdersAsync);
        }
        public HomesDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
