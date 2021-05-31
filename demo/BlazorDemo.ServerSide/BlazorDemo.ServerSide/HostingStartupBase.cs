using System.IO;
using System.Net.Http;
using BlazorDemo.Configuration;
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
        public virtual void Configure(IWebHostBuilder builder) {
            builder.UseEnvironment(EnvironmentName);
            builder.UseStaticWebAssets();

            builder.ConfigureServices(ConfigureServices);
            builder.Configure(ConfigureApp);

            void ConfigureApp(WebHostBuilderContext context, IApplicationBuilder app) {
                string pathBase = Configuration.GetValue<string>("pathBase");
                if (!string.IsNullOrEmpty(pathBase))
                    app.UsePathBase(pathBase);

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

                services.AddSingleton<IProductsFlatProvider, ProductsFlatProvider>();
                services.AddSingleton<IProductCategoriesProvider, ProductCategoriesProvider>();
                services.AddSingleton<ISalesInfoDataProvider, SalesInfoDataProvider>();
                services.AddSingleton<ISalesViewerDataProvider, SalesViewerDataProvider>();
                services.AddSingleton<IFinancialSeriesDataProvider, FinancialSeriesDataProvider>();
                services.AddSingleton<ICurrencyExchangeDataProvider, UsdJpyDataProvider>();
                services.AddSingleton<IUsdJpyCsvFileContentProvider, UsdJpyCsvFileContentProvider>();
                services.AddSingleton<INwindDataProvider, NwindDataProvider>();
                services.AddSingleton<IIssuesDataProvider, IssuesDataProvider>();
                services.AddSingleton<IWorldcitiesDataProvider, WorldcitiesDataProvider>();

                static void ConfigureHttpClient(HttpClient httpClient) {
                    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                };

                static void ConfigureJsonOptions(JsonOptions options) {
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                };
            }
        }

        void IHostingStartup.Configure(IWebHostBuilder builder) {
            Configure(builder);
        }
    }
}
