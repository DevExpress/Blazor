using System;
using BlazorDemo.DataProviders;
using BlazorDemo.DataProviders.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;

namespace BlazorDemo.ServerSide {
    partial class Startup {

        public override string EnvironmentName => "Wasm.AspNetCoreHosted";

        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
            services.AddNotSupportedDemoServices();

            services.AddDbContext<NorthwindContext>(options => {
                var connectionString = ConnectionStringUtils.GetNorthwindConnectionString(context.Configuration);
                if(connectionString != null)
                    options.UseSqlite(connectionString);
            });
            services.AddDbContext<IssuesContext>(options => {
                var connectionString = ConnectionStringUtils.GetIssuesConnectionString(context.Configuration);
                if(connectionString != null)
                    options.UseSqlite(connectionString);
            });
            services.AddDbContext<WorldcitiesContext>(options => {
                var connectionString = ConnectionStringUtils.GetWorlcitiesConnectionString(context.Configuration);
                if(connectionString != null)
                    options.UseSqlite(connectionString);
            });
        }

        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            app.UseBlazorFrameworkFiles();
        }
        public override void Configure(IWebHostBuilder builder) {
            builder.ConfigureAppConfiguration(((context, configurationBuilder) => {
                configurationBuilder.AddInMemoryCollection(new Dictionary<string, string> {
                    ["DataSourcesFolder"] = Path.Combine(System.AppContext.BaseDirectory, "DataSources")
                });
            }));
            base.Configure(builder);
        }
    }
}
