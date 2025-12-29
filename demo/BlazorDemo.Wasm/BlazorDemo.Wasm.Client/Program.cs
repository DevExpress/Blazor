using System;
using System.Diagnostics.CodeAnalysis;
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

            var azureOpenAIEndpoint = "https://public-api.devexpress.com/demo-openai";
            var azureOpenAIKey = "DEMO";
            var deploymentName = "gpt-4.1";

            services.AddDemoServices(azureOpenAIEndpoint, azureOpenAIKey, deploymentName, true);
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
            services.AddSingleton<IVehiclesXmlFileContentProvider, VehiclesXmlFileContentProviderWasm>();
            services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
            services.AddSingleton<IWeatherSummaryDataProvider, WeatherSummaryDataProviderWasm>();
            services.AddSingleton<IWorldcitiesDataProvider, WorldcitiesDataProvider>();
            services.AddSingleton<IGlobalTemperatureIndexDataProvider, GlobalTemperatureIndexDataProviderWasm>();
            services.AddSingleton<IFileSystemDataProvider, FileSystemDataProviderWasm>();

            var stockQuoteService = new StockQuoteService();
            var stockQuoteByRegionService = new StockQuoteByRegionService();
            var stockQuoteTimerService = new StockQuoteChangeTimerService(stockQuoteService, stockQuoteByRegionService);
            services.AddSingleton<IStockQuoteService>(_ => stockQuoteService);
            services.AddSingleton<IStockQuoteByRegionService>(_ => stockQuoteByRegionService);
            services.AddSingleton(stockQuoteTimerService);

            var barGaugeTemperatureMeasurerService = new BarGaugeTemperatureMeasurerService();
            var barGaugeTemperatureMeasurerTimerService = new BarGaugeTemperatureMeasurerTimerService(barGaugeTemperatureMeasurerService);
            services.AddSingleton<IBarGaugeTemperatureMeasurerService>(_ => barGaugeTemperatureMeasurerService);
            services.AddSingleton(barGaugeTemperatureMeasurerTimerService);

            var networkSpeedTesterService = new NetworkSpeedTesterService();
            var networkSpeedTesterTimerServiceTimerService = new NetworkSpeedTesterTimerServiceTimerService(networkSpeedTesterService);
            services.AddSingleton<INetworkSpeedTesterService>(_ => networkSpeedTesterService);
            services.AddSingleton(networkSpeedTesterTimerServiceTimerService);

            services.AddSingleton<IHistogramDataProvider, HistogramDataProvider>();
            services.AddSingleton<IDocumentProvider, DocumentProviderWasm>();
            services.AddSingleton<IHomesDataProvider, HomesDataProvider>();
            services.AddSingleton<ISalesDataProvider, SalesDataProvider>();
            // Editable should be scoped
            services.AddScoped<INwindDataProvider, NwindDataProvider>();
            services.AddScoped<IEmployeeTaskEditableDataProvider, EmployeeTaskEditableDataProvider>();

            services.AddSingleton<IChartBirthLifeDataProvider, ChartBirthLifeDataProvider>();
            services.AddSingleton<IChartApplePriceDataProvider, ChartApplePriceDataProvider>();
            services.AddSingleton<IChartTemperatureDataProvider, ChartTemperatureDataProvider>();
            services.AddSingleton<IChartAverageTemperatureDataProvider, ChartAverageTemperatureDataProvider>();

            services.AddSingleton<IChartContinuousDataProvider, ChartContinuousDataProvider>();
            services.AddSingleton<IChartDiscreteDataProvider, ChartDiscreteDataProvider>();
            services.AddSingleton<IChartSpiderDataProvider, ChartSpiderDataProvider>();
            services.AddSingleton<IChartWindRoseDataProvider, ChartWindRoseDataProvider>();
            services.AddSingleton<ISparklineDataProvider, SparklineDataProvider>();
            services.AddSingleton<ISankeyDataProvider, SankeyDataProvider>();
            services.AddSingleton<IMapApiKeyProvider, MapApiKeyProvider>();
            services.AddSingleton<IHtmlEditorStringDataProvider, HtmlEditorStringDataProvider>();

            services.AddSingleton<IEmployeeTaskDataProvider, EmployeeTaskDataProvider>();
            services.AddSingleton<ISpaceObjectDataProvider, SpaceObjectDataProvider>();
            services.AddSingleton<ISalesByRegionDataProvider, SalesByRegionDataProvider>();
            services.AddSingleton<ICarouselImageDataProvider, CarouselImageDataProvider>();
            services.AddSingleton<ISalesAmountDataProvider, SalesAmountDataProvider>();
            services.AddSingleton<IRangeSelectorZoomingDataProvider, RangeSelectorZoomingDataProvider>();
            services.AddSingleton<IPopulationDataProvider, PopulationDataProvider>();
            services.AddSingleton<IPromptSuggestionsDataProvider, PromptSuggestionsDataProvider>();
            services.AddSingleton<IOrderDataProvider, OrderDataProvider>();
            services.AddSingleton<IChatResourcesDataProvider, AIChatResourcesDataProviderWasm>();

            services.AddNotSupportedDemoServices();
#pragma warning disable DX0006
            var client = new HttpClient() { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            builder.Services.AddScoped(sp => client);
#pragma warning restore DX0006
            services.AddSingleton<IDemoVersion, DemoVersion>(x => {
                var dxVersion = new Version(AssemblyInfo.Version);
                return new DemoVersion(new Version(dxVersion.Major, dxVersion.Minor, dxVersion.Build).ToString());
            });
            services.AddSingleton<DemoConfiguration>();
            services.AddScoped<DemoThemeService>();
            services.AddScoped<IDemoStaticResourceService, DemoStaticResourceService>();

            services.AddScoped<CspNonceService>();
            services.AddScoped<ICspNonceService>(sp => sp.GetRequiredService<CspNonceService>());
            services.AddScoped<ICspNonceWriter>(sp => sp.GetRequiredService<CspNonceService>());

            builder.RootComponents.AddDocumentMetadata();
            builder.RootComponents.Add<App>("#app");


            await builder.Build().RunAsync();
        }
    }
}
