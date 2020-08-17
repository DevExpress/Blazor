using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class FlatProductsProvider : RemoteDataProviderBase, IFlatProductsProvider {
        public FlatProductsProvider(RemoteDataProviderLoader loader) : base(loader) {
        }

        public Task<IEnumerable<ProductFlat>> LoadAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, LoadAsync);
        }

        public Task Add(ProductFlat product) {
            return Loader.AddEntity(this, product);
        }

        public Task Remove(ProductFlat item) {
            return Loader.DeleteEntity(this, item);
        }
    }
}
