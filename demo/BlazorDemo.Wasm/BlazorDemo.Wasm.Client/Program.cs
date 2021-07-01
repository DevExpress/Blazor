using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using BlazorDemo.DataProviders;
using BlazorDemo.DataProviders.Implementation;
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

            services.AddSingleton<IProductCategoriesProvider, ProductCategoriesProvider>();
            services.AddSingleton<ISalesInfoDataProvider, SalesInfoDataProvider>();
            services.AddSingleton<IFinancialSeriesDataProvider, FinancialSeriesDataProvider>();
            services.AddSingleton<ICurrencyExchangeDataProvider, UsdJpyDataProviderWasm>();
            services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            services.AddSingleton<IWeatherSummaryDataProvider, WeatherSummaryDataProviderWasm>();
            services.AddSingleton<IWorldcitiesDataProvider, WorldcitiesDataProvider>();
            // Editable should be scoped
            services.AddScoped<IProductsFlatProvider, ProductsFlatProvider>();
            services.AddScoped<INwindDataProvider, NwindDataProvider>();

            services.AddNotSupportedDemoServices();

            var client = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            builder.Services.AddScoped(sp => client);

            services.AddSingleton<IDemoVersion, DemoVersion>(x => {
                var dxVersion = new Version(AssemblyInfo.Version);
                return new DemoVersion(new Version(dxVersion.Major, dxVersion.Minor, dxVersion.Build).ToString());
            });
            services.AddSingleton<DemoConfiguration>();
            services.AddScoped<IDemoThemesConfigurationCookieAccessor, DemoThemesConfigurationCookieAccessor>();
            services.AddScoped<DemoThemesConfiguration>();

            builder.RootComponents.AddDocumentMetadata();
            builder.RootComponents.Add<App>("#app");


            await builder.Build().RunAsync();
        }
    }

    class DemoThemesConfigurationCookieAccessor : IDemoThemesConfigurationCookieAccessor {
        public string GetCookie(string name) {
            return null;
        }
    }
}
