using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Demo.Blazor.Services;
using Demo.Blazor.Model;
using Demo.Blazor.Model.SalesViewer;
using Microsoft.EntityFrameworkCore;
using Demo.Blazor;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.Extensions.Options;
using DevExpress.Blazor;

namespace BlazorDemo.ServerSide
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            #if DEBUG
                services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
            #endif

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<WeatherForecastService>();
            services.AddDbContext<FMRDemoContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("GridLargeDataConnectionString"), opt => opt.UseRowNumberForPaging()));
            services.AddDbContext<ContosoRetailContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PivotGridLargeDataConnectionString")));

            services.Configure<DemoConfiguration>(Configuration.GetSection("DemoConfiguration"));
            services.AddTransient<ProductService>();
            services.AddSingleton<FlatProductService>();
            services.AddSingleton<CountryNamesService>();
            services.AddSalesViewerService();
            services.AddDocumentMetadata((serviceProvider, registrator) =>
            {
                DemoConfiguration config = serviceProvider.GetService<IOptions<DemoConfiguration>>().Value;
                config.RegisterPagesMetadata(registrator);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
