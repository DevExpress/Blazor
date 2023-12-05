using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class ExperimentResultDataProvider : RemoteDataProviderBase, IExperimentResultDataProvider {
        public Task<IEnumerable<DataPoint>> GetResultAsync(CancellationToken ct = default) {
            return Loader.LoadRemoteEntities(this, GetResultAsync);
        }

        public ExperimentResultDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
