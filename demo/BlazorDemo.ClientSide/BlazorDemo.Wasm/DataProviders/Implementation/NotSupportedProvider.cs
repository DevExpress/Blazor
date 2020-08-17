using System;
using System.Threading.Tasks;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class NotSupportedProvider {
        private static readonly Task<IObservable<int>> _loadingState = Task.FromResult<IObservable<int>>(null);

        public Task<IObservable<int>> GetLoadingStateAsync() {
            return _loadingState;
        }
    }
}

namespace Microsoft.Extensions.DependencyInjection {
    public static class NotSupportedProviderExtensions {
        public static IServiceCollection AddNotSupportedDemoServices(this IServiceCollection serviceCollection) {
            serviceCollection.AddSingleton<IRentInfoDataProvider, RentInfoDataProvider>();
            serviceCollection.AddSingleton<IContosoRetailDataProvider, ContosoRetailDataProvider>();
            return serviceCollection;
        }
    }
}
