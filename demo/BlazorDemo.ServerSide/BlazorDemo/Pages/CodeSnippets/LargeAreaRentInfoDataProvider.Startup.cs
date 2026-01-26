using BlazorDemo.DataProviders;
using Microsoft.Extensions.DependencyInjection;

public class Startup {
    public void ConfigureServices(IServiceCollection services) {
        // ...
        services.AddScoped<ILargeAreaRentInfoDataProvider, LargeAreaRentInfoDataProvider>();
    }
}
