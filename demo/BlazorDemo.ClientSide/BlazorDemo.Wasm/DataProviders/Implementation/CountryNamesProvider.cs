using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class CountryNamesProvider : RemoteDataProviderBase, ICountryNamesProvider {
        public Task<IEnumerable<Country>> LoadAsync(CancellationToken ct) {
            return Loader.LoadRemoteEntities(this, LoadAsync);
        }

        public CountryNamesProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
