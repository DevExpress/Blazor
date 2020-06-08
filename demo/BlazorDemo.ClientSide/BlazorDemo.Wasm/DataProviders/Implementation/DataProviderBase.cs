using System;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    abstract class RemoteDataProviderBase : IDataProvider {
        protected RemoteDataProviderLoader Loader { get; }

        private protected RemoteDataProviderBase(RemoteDataProviderLoader loader) {
            Loader = loader;
        }

        public Task<IObservable<int>> GetLoadingStateAsync() {
            return Loader.GetDataProviderStateAsync(this);
        }
    }
}