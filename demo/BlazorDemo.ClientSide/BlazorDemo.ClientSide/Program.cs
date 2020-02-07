using System.Threading.Tasks;
using Demo.Blazor;
using Demo.Blazor.Model;
using Demo.Blazor.Services;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BlazorDemo.ClientSide
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            
            builder.Services.AddDevExpressBlazor();
            builder.Services.AddScoped<WeatherForecastService>();
            builder.Services.AddSingleton<IOptions<DemoConfiguration>, ClientSideDemoConfiguration>();
            builder.Services.AddDbContext<FMRDemoContext>(options =>
                options.UseSqlServer("YOUR CONNECTION STRING HERE", opt => opt.UseRowNumberForPaging()));
            builder.Services.AddDbContext<ContosoRetailContext>(options =>
                options.UseSqlServer("YOUR CONNECTION STRING HERE"));

            //builder.Services.Configure<Demo.Blazor.DemoConfiguration>(Configuration.GetSection("DemoConfiguration"));
            builder.Services.AddTransient<ProductService>();
            builder.Services.AddSingleton<FlatProductService>();
            builder.Services.AddTransient<EmployeeService>();
            builder.Services.AddSingleton<CountryNamesService>();
            builder.Services.AddSalesViewerService();

            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
