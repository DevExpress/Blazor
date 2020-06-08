using BlazorDemo.DataProviders;

namespace Microsoft.Extensions.DependencyInjection {
    public static class DataProviderServiceCollectionExtensions {
        public static IServiceCollection AddDemoDataProvider<TContract, TImplementation>(this IServiceCollection collection) 
            where TContract : class, IDataProvider
            where TImplementation : class, TContract {
            collection.AddSingleton<TImplementation>();
            collection.AddSingleton<TContract>(sp => sp.GetService<TImplementation>());
            collection.AddSingleton<IDataProvider>(sp => sp.GetService<TImplementation>());
            return collection;
        }
    }
}