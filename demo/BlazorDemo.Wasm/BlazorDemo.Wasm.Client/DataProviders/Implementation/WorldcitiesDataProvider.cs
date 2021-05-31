using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Worldcities;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class WorldcitiesDataProvider : RemoteDataProviderBase, IWorldcitiesDataProvider {
        public Task<IEnumerable<Country>> GetCountriesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetCountriesAsync);
        }
        public Task<IEnumerable<City>> GetCitiesAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetCitiesAsync);
        }

        public WorldcitiesDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}

