using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.Implementation;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Wasm {
    public class Program {
        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            var services = builder.Services;

            services.AddDemoServices();
            services.AddTransient<EntityDataContainer>();

            services.AddTransient<RemoteDataProviderLoader>();

            services.AddSingleton<ICountryNamesProvider, CountryNamesProvider>();
            services.AddSingleton<IFlatProductsProvider, FlatProductsProvider>();
            services.AddSingleton<IProductCategoriesProvider, ProductCategoriesProvider>();
            services.AddSingleton<IProductsProvider, ProductsProvider>();
            services.AddSingleton<ISalesInfoDataProvider, SalesInfoDataProvider>();
            services.AddSingleton<ISalesViewerDataProvider, SalesViewerDataProvider>();
            services.AddNotSupportedDemoServices();
            services.AddOptions<SeoConfiguration>("BlazorDemo");
            
            var client = new HttpClient()
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            };

            builder.Services.AddTransient(sp => client);

            using var response = await client.GetAsync("SeoConfiguration.json");
            using var stream = await response.Content.ReadAsStreamAsync();

            builder.Configuration.AddJsonStream(stream);
            
            builder.RootComponents.AddDocumentMetadata();
            builder.RootComponents.Add<App>("app");
            

            await builder.Build().RunAsync();
        }
    }
}