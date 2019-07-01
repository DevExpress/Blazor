using Demo.Blazor.Services;
using Demo.Blazor;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Demo.Blazor.Model;
using Microsoft.EntityFrameworkCore;

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

            //services.Configure<Demo.Blazor.DemoConfiguration>(Configuration.GetSection("DemoConfiguration"));
            services.AddTransient<ProductService>();
            services.AddSingleton<CountryNamesService>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
