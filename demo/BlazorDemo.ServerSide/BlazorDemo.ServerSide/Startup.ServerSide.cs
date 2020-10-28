using System.Net.Http;
using BlazorDemo.Configuration;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorDemo.ServerSide {

    partial class Startup {
        public override string EnvironmentName => "ServerSide";
        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services) {
            services.AddServerSideBlazor();

            var optionsBuilder = services.AddOptions();
            optionsBuilder.AddOptions<SeoConfiguration>("BlazorDemo");


            services.AddScoped<HttpClient>(serviceProvider => serviceProvider.GetService<IHttpClientFactory>().CreateClient());

            services.AddScoped<IContosoRetailDataProvider, ContosoRetailDataProvider>();
            services.AddScoped<IRentInfoDataProvider, RentInfoDataProvider>();

            services.AddDbContext<FMRDemoContext>(options => {
                var connectionString = ConnectionStringUtils.GetGridLargeDataConnectionString(context.Configuration);
                if(connectionString != null)
                    options.UseSqlServer(connectionString);
            });

            services.AddDbContext<ContosoRetailContext>(options => {
                var connectionString = ConnectionStringUtils.GetPivotGridLargeDataConnectionString(context.Configuration);
                if(connectionString != null)
                    options.UseSqlServer(connectionString);
            });
        }
        public override void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
            if(env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            } else {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints => endpoints.MapBlazorHub());
        }
    }
}
