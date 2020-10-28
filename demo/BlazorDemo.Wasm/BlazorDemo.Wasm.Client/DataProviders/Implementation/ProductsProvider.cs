using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class ProductsProvider : RemoteDataProviderBase, IProductsProvider {
        public Task<IEnumerable<Product>> LoadAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, LoadAsync);
        }

        public Task RemoveAsync(Product product) {
            return Loader.DeleteEntity(this, product);
        }

        public Task AddAsync(Product product) {
            return Loader.AddEntity(this, product);
        }

        public ProductsProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
