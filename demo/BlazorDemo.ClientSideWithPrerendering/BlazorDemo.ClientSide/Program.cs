using System.Threading.Tasks;
using Demo.Blazor;
using Demo.Blazor.Model;
using Demo.Blazor.Services;
using DevExpress.Blazor.DocumentMetadata;
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

            builder.Services.AddTransient<ProductService>();
            builder.Services.AddSingleton<FlatProductService>();
            builder.Services.AddTransient<EmployeeService>();
            builder.Services.AddSingleton<CountryNamesService>();
            builder.Services.AddSalesViewerService();
            builder.Services.AddDocumentMetadata((serviceProvider, registrator) =>
            {
                DemoConfiguration config = serviceProvider.GetService<IOptions<DemoConfiguration>>().Value;
                config.RegisterPagesMetadata(registrator);
            });
            
            builder.RootComponents.Add<App>("app");
            builder.RootComponents.Add<DocumentMetadataComponent>("head");

            await builder.Build().RunAsync();
        }
    }
}
