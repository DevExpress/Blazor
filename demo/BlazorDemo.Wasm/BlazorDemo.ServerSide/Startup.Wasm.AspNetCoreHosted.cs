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

            services.AddDbContextFactory<NorthwindContext>(opt => {
                var connectionString = ConnectionStringUtils.GetNorthwindConnectionString(context.Configuration);
                if(!string.IsNullOrEmpty(connectionString))
                    opt.UseSqlServer(connectionString);
                else
                    opt.UseSqlite(ConnectionStringUtils.GetNorthwindSqliteConnectionString(context.Configuration));
            });
            services.AddDbContextFactory<HomesContext>(opt => {
                opt.UseSqlite(ConnectionStringUtils.GetHomesSqliteConnectionString(context.Configuration));
            });
            services.AddDbContextFactory<IssuesContext>(opt => {
                var connectionString = ConnectionStringUtils.GetIssuesConnectionString(context.Configuration);
                if(!string.IsNullOrEmpty(connectionString))
                    opt.UseSqlServer(connectionString);
                else
                    opt.UseSqlite(ConnectionStringUtils.GetIssuesSqliteConnectionString(context.Configuration));
            });
            services.AddDbContextFactory<WorldcitiesContext>(opt => {
                var connectionString = ConnectionStringUtils.GetWorlcitiesConnectionString(context.Configuration);
                if(!string.IsNullOrEmpty(connectionString))
                    opt.UseSqlServer(connectionString);
                else
                    opt.UseSqlite(ConnectionStringUtils.GetWorlcitiesSqliteConnectionString(context.Configuration));
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
            ReportingHostingStartup.Configure(builder);
        }
    }
}
