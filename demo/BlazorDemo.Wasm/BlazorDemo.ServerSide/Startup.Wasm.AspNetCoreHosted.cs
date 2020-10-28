using System;
using BlazorDemo.DataProviders;
using BlazorDemo.DataProviders.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlazorDemo.ServerSide {
    partial class Startup {

        public override string EnvironmentName => "Wasm.AspNetCoreHosted";

        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
            services.AddNotSupportedDemoServices();
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseBlazorFrameworkFiles();
        }
    }
}
