using System.Net.Http;
using BlazorDemo.DataProviders;
using BlazorDemo.DataProviders.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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

        void IHostingStartup.Configure(IWebHostBuilder builder) {
            builder.UseEnvironment(EnvironmentName);
            builder.UseStaticWebAssets();

            builder.ConfigureServices(ConfigureServices);
            builder.Configure(ConfigureApp);

            void ConfigureApp(WebHostBuilderContext context, IApplicationBuilder app) {
                app.UseResponseCompression();
                app.UseRouting();

                app.UseStaticFiles();
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

                services.AddSingleton<ICountryNamesProvider, CountryNamesProvider>();
                services.AddSingleton<IFlatProductsProvider, FlatProductsProvider>();
                services.AddSingleton<IProductCategoriesProvider, ProductCategoriesProvider>();
                services.AddSingleton<IProductsProvider, ProductsProvider>();
                services.AddSingleton<ISalesInfoDataProvider, SalesInfoDataProvider>();
                services.AddSingleton<ISalesViewerDataProvider, SalesViewerDataProvider>();


                static void ConfigureHttpClient(HttpClient httpClient) {
                    httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
                };

                static void ConfigureJsonOptions(JsonOptions options) {
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                };
            }
        }
    }
}
