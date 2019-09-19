using Demo.Blazor.Services;
using Demo.Blazor;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Demo.Blazor.Model;
using Microsoft.EntityFrameworkCore;
using DevExpress.Blazor.DocumentMetadata;

namespace BlazorDemo.ClientSide
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddScoped<WeatherForecastService>();
            services.AddSingleton<IOptions<DemoConfiguration>, ClientSideDemoConfiguration>();
            services.AddDbContext<FMRDemoContext>(options =>
                options.UseSqlServer("YOUR CONNECTION STRING HERE", opt => opt.UseRowNumberForPaging()));
            services.AddDbContext<ContosoRetailContext>(options =>
                options.UseSqlServer("YOUR CONNECTION STRING HERE"));

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

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
            app.AddComponent<DocumentMetadataComponent>("head");
        }
    }
}
