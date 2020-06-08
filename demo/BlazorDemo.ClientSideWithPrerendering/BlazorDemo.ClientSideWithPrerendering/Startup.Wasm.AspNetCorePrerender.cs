using BlazorDemo.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorDemo.ServerSide {
    partial class Startup : HostingStartupBase {
        public override string EnvironmentName => "Wasm.AspNetCorePrerender";

        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
            services.AddNotSupportedDemoServices();
            services.AddOptions<SeoConfiguration>("BlazorDemo");
        }
        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseBlazorFrameworkFiles();
        }
    }
}
