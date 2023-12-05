using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Configuration;
using BlazorDemo.DataProviders;
using BlazorDemo.DataProviders.Implementation;
using BlazorDemo.Services;
using BlazorDemo.Wasm.DataProviders.Implementation;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.Wasm {
    public class Program {
        public static async Task Main(string[] args) {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            var services = builder.Services;

            services.AddDemoServices(true);
            services.AddTransient<EntityDataContainer>();

            services.AddTransient<RemoteDataProviderLoader>();

            services.AddSingleton<ISalesInfoDataProvider, SalesInfoDataProvider>();
            services.AddSingleton<IExperimentResultDataProvider, ExperimentResultDataProvider>();
            services.AddSingleton<IPopulationCorrelationDataProvider, PopulationCorrelationDataProvider>();
            services.AddSingleton<IScatterRandomDataProvider, ScatterRandomDataProvider>();
            services.AddSingleton<IFinancialSeriesDataProvider, FinancialSeriesDataProvider>();
            services.AddSingleton<IChartDrillDownDataProvider, ChartDrillDownDataProvider>();
            services.AddSingleton<IPopulationStructureDataProvider, PopulationAgeStructureDataProvider>();
            services.AddSingleton<ICurrencyExchangeDataProvider, UsdJpyDataProviderWasm>();
            services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            services.AddSingleton<IWeatherSummaryDataProvider, WeatherSummaryDataProviderWasm>();
            services.AddSingleton<IWorldcitiesDataProvider, WorldcitiesDataProvider>();
            services.AddSingleton<IGlobalTemperatureIndexDataProvider, GlobalTemperatureIndexDataProviderWasm>();

            var stockQuoteService = new StockQuoteService();
            var stockQuoteTimerService = new StockQuoteChangeTimerService(stockQuoteService);
            services.AddSingleton<IStockQuoteService>(_ => stockQuoteService);
            services.AddSingleton(stockQuoteTimerService);

            services.AddSingleton<IHistogramDataProvider, HistogramDataProvider>();
            services.AddSingleton<IDocumentProvider, DocumentProviderWasm>();
            services.AddSingleton<IHomesDataProvider, HomesDataProvider>();
            // Editable should be scoped
            services.AddScoped<INwindDataProvider, NwindDataProvider>();

            services.AddScoped<IChartBirthLifeDataProvider, ChartBirthLifeDataProvider>();

            services.AddNotSupportedDemoServices();

            var client = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            builder.Services.AddScoped(sp => client);

            services.AddSingleton<IDemoVersion, DemoVersion>(x => {
                var dxVersion = new Version(AssemblyInfo.Version);
                return new DemoVersion(new Version(dxVersion.Major, dxVersion.Minor, dxVersion.Build).ToString());
            });
            services.AddSingleton<DemoConfiguration>();
            services.AddScoped<DemoThemeService>();
            services.AddScoped<IDemoStaticResourceService, DemoStaticResourceService>();

            builder.RootComponents.AddDocumentMetadata();
            builder.RootComponents.Add<App>("#app");


            await builder.Build().RunAsync();
        }
    }
}
