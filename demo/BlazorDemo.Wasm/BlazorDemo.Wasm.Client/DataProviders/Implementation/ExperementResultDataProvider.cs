using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class ExperementResultDataProvider : RemoteDataProviderBase, IExperementResultDataProvider {
        public Task<IEnumerable<DataPoint>> GetResultAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetResultAsync);
        }

        public ExperementResultDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
