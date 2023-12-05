using System.Net.Http;
using BlazorDemo.DataProviders;
using BlazorDemo.DataProviders.Implementation;
using BlazorDemo.Wasm.Server.DataProviders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlazorDemo.ServerSide.Startup))]

namespace BlazorDemo.ServerSide {
    partial class Startup : HostingStartupBase { }

    abstract class HostingStartupBase : IHostingStartup {
        protected IConfiguration Configuration { get; private set; }

        public abstract string EnvironmentName { get; }

        public abstract void Configure(IApplicationBuilder app, IWebHostEnvironment env);
        public abstract void ConfigureServices(WebHostBuilderContext context, IServiceCollection services);
#pragma warning disable DX0006
        public virtual void Configure(IWebHostBuilder builder) {
            builder.UseEnvironment(EnvironmentName);
            builder.UseStaticWebAssets();

            builder.ConfigureServices(ConfigureServices);
            builder.Configure(ConfigureApp);

            void ConfigureApp(WebHostBuilderContext context, IApplicationBuilder app) {
                string pathBase = Configuration.GetValue<string>("pathbase");
                if(!string.IsNullOrEmpty(pathBase)) {
                    string pathString = pathBase.StartsWith('/') ? pathBase : "/" + pathBase;
                    app.UsePathBase(pathString);
                }

                app.UseRequestLocalization(new RequestLocalizationOptions().SetDefaultCulture("en-US"));

                app.UseResponseCompression();
                app.UseRouting();

                var provider = new FileExtensionContentTypeProvider();
                provider.Mappings[".razor"] = "text/plain";
                provider.Mappings[".cshtml"] = "text/plain";
                provider.Mappings[".cs"] = "text/plain";
                app.UseStaticFiles(new StaticFileOptions { ContentTypeProvider = provider });

                app.UseAuthorization();

                app.UseEndpoints(endpoints => {
                    endpoints.MapControllers();

                    endpoints.MapFallbackToPage("/_Host");
                });
                Configure(app, context.HostingEnvironment);
            };

            void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
                Configuration = services.BuildServiceProvider().GetService<IConfiguration>();

                services.AddHttpClient<HttpClient>(ConfigureHttpClient);

                this.ConfigureServices(context, services);

                services.AddRazorPages();
                services.AddResponseCompression(options => {
                    options.EnableForHttps = true;
                    options.MimeTypes = new[] {
                            "text/plain",
                            "text/css",
                            "application/javascript",
                            "text/html",
                            "application/xml",
                            "text/xml",
                            "application/json",
                            "text/json"
                        };
                });
                services.AddControllers().AddJsonOptions(ConfigureJsonOptions);
                services.AddDemoServices();

                services.AddSingleton<ISalesInfoDataProvider, SalesInfoDataProvider>();
                services.AddSingleton<IExperimentResultDataProvider, ExperimentResultDataProvider>();
                services.AddSingleton<IScatterRandomDataProvider, ScatterRandomDataProvider>();
                services.AddSingleton<IPopulationCorrelationDataProvider, PopulationCorrelationDataProvider>();
                services.AddSingleton<IFinancialSeriesDataProvider, FinancialSeriesDataProvider>();
                services.AddSingleton<IChartDrillDownDataProvider, ChartDrillDownDataProvider>();
                services.AddSingleton<IPopulationStructureDataProvider, PopulationAgeStructureDataProvider>();
                services.AddSingleton<ICurrencyExchangeDataProvider, UsdJpyDataProvider>();
                services.AddSingleton<IUsdJpyCsvFileContentProvider, UsdJpyCsvFileContentProvider>();
                services.AddSingleton<IWeatherSummaryCsvFileContentProvider, WeatherSummaryCsvFileContentProvider>();
                services.AddSingleton<IWeatherSummaryDataProvider, WeatherSummaryDataProvider>();
                services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
                services.AddSingleton<IWorldcitiesDataProvider, WorldcitiesDataProvider>();
                services.AddSingleton<IGlobalTemperatureIndexDataProvider, GlobalTemperatureIndexDataProvider>();
                services.AddSingleton<IGlobalTemperatureIndexFileContentProvider, GlobalTemperatureIndexFileContentProvider>();
                services.AddSingleton<IHistogramDataProvider, HistogramDataProvider>();
                services.AddSingleton<IDocumentProvider, DocumentProvider>();
                services.AddSingleton<IChartBirthLifeDataProvider, ChartBirthLifeDataProvider>();
                // Editable should be scoped
                services.AddScoped<INwindDataProvider, NwindDataProvider>();
                services.AddScoped<IHomesDataProvider, HomesDataProvider>();

                static void ConfigureHttpClient(HttpClient httpClient) {
                    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                };

                static void ConfigureJsonOptions(JsonOptions options) {
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                };
            }
        }
#pragma warning restore DX0006

        void IHostingStartup.Configure(IWebHostBuilder builder) {
            Configure(builder);
        }
    }
}
