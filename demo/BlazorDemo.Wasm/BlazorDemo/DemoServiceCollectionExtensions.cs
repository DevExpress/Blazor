using System;
using BlazorDemo.Configuration;
using BlazorDemo.Services;
using DevExpress.Blazor.DocumentMetadata;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


namespace BlazorDemo {

    public static class DemoServiceCollectionExtensions {
        public static void AddDemoServices(this IServiceCollection services) {
            services.AddScoped<DemoService>();
            services.AddScoped<EmployeeService>();
            services.AddScoped<FlatProductService>();
            services.AddScoped<ProductService>();
            services.AddScoped<RentInfoDataService>();
            services.AddScoped<WeatherForecastService>();
            services.AddScoped<SupplierService>();
            services.AddScoped<CustomersService>();
            services.AddDevExpressBlazor();

            services.AddDocumentMetadata(ConfigureMetadata);
            services.AddSingleton<DemoConfiguration>();

            static void ConfigureMetadata(IServiceProvider sp, IDocumentMetadataCollection metadataCollection) {
                sp.GetService<DemoConfiguration>().ConfigureMetadata(metadataCollection);
            }
        }
    }
}
