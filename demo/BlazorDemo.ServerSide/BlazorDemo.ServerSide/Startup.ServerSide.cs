using System;
using System.IO;
using System.Net.Http;
using BlazorDemo.Configuration;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using BlazorDemo.DemoData;
using BlazorDemo.Services;

namespace BlazorDemo.ServerSide {

    partial class Startup {

        public override string EnvironmentName => "ServerSide";
#pragma warning disable DX0006
        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
#if DEBUG
            bool detailedErrors = true;
#else
            bool detailedErrors = Configuration.GetValue("detailedErrors", false);
#endif
            services.AddServerSideBlazor()
                .AddCircuitOptions(x => x.DetailedErrors = detailedErrors)
                .AddHubOptions(options => {
                    options.EnableDetailedErrors = detailedErrors;
                });
            var optionsBuilder = services.AddOptions();
            optionsBuilder.AddOptions<DemoModel>("BlazorDemo");

            services.AddSingleton<IDemoVersion, DemoVersion>(x => {
                string customVersion = Configuration.GetValue<string>("dxversion");
                if(!string.IsNullOrEmpty(customVersion))
                    customVersion = " " + customVersion.TrimStart();
                var dxVersion = new Version(AssemblyInfo.Version);
                return new DemoVersion(new Version(dxVersion.Major, dxVersion.Minor, dxVersion.Build) + customVersion);
            });
            services.AddScoped<HttpClient>(serviceProvider => serviceProvider.GetService<IHttpClientFactory>().CreateClient());

            services.AddScoped<IContosoRetailDataProvider, ContosoRetailDataProvider>();
            services.AddScoped<IRentInfoDataProvider, RentInfoDataProvider>();

            services.AddDbContextFactory<HomesContext>(opt => {
                opt.UseSqlite(ConnectionStringUtils.GetHomesSqliteConnectionString(context.Configuration));
            });

            services.AddDbContextFactory<NorthwindContext>(opt => {
                var connectionString = ConnectionStringUtils.GetNorthwindConnectionString(context.Configuration);
                if(!string.IsNullOrEmpty(connectionString))
                    opt.UseSqlServer(connectionString);
                else
                    opt.UseSqlite(ConnectionStringUtils.GetNorthwindSqliteConnectionString(context.Configuration));
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
            services.AddDbContextFactory<RentInfoContext>(opt => {
                var connectionString = ConnectionStringUtils.GetGridLargeDataConnectionString(context.Configuration);
                if(!string.IsNullOrEmpty(connectionString))
                    opt.UseSqlServer(connectionString);
            });
            services.AddDbContextFactory<ContosoRetailContext>(opt => {
                var connectionString = ConnectionStringUtils.GetPivotGridLargeDataConnectionString(context.Configuration);
                if(!string.IsNullOrEmpty(connectionString))
                    opt.UseSqlServer(connectionString);
            });
            services.AddSingleton<IStockQuoteService, StockQuoteService>();
            services.AddHostedService<StockQuoteChangeTimerService>(
                provider => new StockQuoteChangeTimerService((StockQuoteService)provider.GetRequiredService<IStockQuoteService>())
            );
        }
#pragma warning restore DX0006
        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions {
                ServeUnknownFileTypes = true
            });
            app.UseEndpoints(endpoints => endpoints.MapBlazorHub());
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
