using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class ProductCategoriesProvider : RemoteDataProviderBase, IProductCategoriesProvider {
        public Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetProductCategoriesAsync);
        }

        public ProductCategoriesProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
