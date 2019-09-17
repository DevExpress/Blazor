using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Blazor.Model.SalesViewer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Blazor.Services {
    public class SalesViewerService {
        static readonly SalesViewerService _instance = new SalesViewerService();

        protected Lazy<SalesViewerDataGenerator> DataGenerator { get; }
        protected Lazy<Task> DataGenerated { get; }
        protected SalesViewerContext DataContext { get; }

        public SalesViewerService() {
            DataContext = new SalesViewerContext();
            DataGenerator = new Lazy<SalesViewerDataGenerator>(() => new SalesViewerDataGenerator(DataContext));
            DataGenerated = new Lazy<Task>(() => GenerateData());
        }
        Task GenerateData() {
            return DataGenerator.Value
                   .MapTableToSeedMethod(c => c.Regions, d => d.CreateRegions())
                   .MapTableToSeedMethod(c => c.Cities, d => d.CreateCities())
                   .MapTableToSeedMethod(c => c.Channels, d => d.CreateChannels())
                   .MapTableToSeedMethod(c => c.Sectors, d => d.CreateSectors())
                   .MapTableToSeedMethod(c => c.Contacts, d => d.CreateContacts())
                   .MapTableToSeedMethod(c => c.Customers, d => d.CreateCustomers())
                   .MapTableToSeedMethod(c => c.Plants, d => d.CreatePlants())
                   .MapTableToSeedMethod(c => c.Products, d => d.CreateProducts())
                   .MapTableToSeedMethod(c => c.Sales, d => d.CreateSales())
                   .Generate();
        }
        async Task<IEnumerable<T>> GetDataTable<T>(Func<SalesViewerContext, IEnumerable<T>> dataGetter) {
            await DataGenerated.Value;
            return dataGetter(DataContext);
        }
        public Task<IEnumerable<Channel>> GetChannels() => GetDataTable(d => d.Channels);
        public Task<IEnumerable<City>> GetCities() => GetDataTable(d => d.Cities);
        public Task<IEnumerable<Contact>> GetContacts() => GetDataTable(d => d.Contacts);
        public Task<IEnumerable<Customer>> GetCustomers() => GetDataTable(d => d.Customers);
        public Task<IEnumerable<Plant>> GetPlants() => GetDataTable(d => d.Plants);
        public Task<IEnumerable<Product>> GetProducts() => GetDataTable(d => d.Products);
        public Task<IEnumerable<Region>> GetRegions() => GetDataTable(d => d.Regions);
        public Task<IEnumerable<Sale>> GetSales() => GetDataTable(d => d.Sales);
        public Task<IEnumerable<Sector>> GetSectors() => GetDataTable(d => d.Sectors);


        public static void RegisterSingleton(IServiceCollection services) {
            services.AddSingleton<SalesViewerService>((serviceProvider) => _instance);
            Task.WaitAll(_instance.DataGenerated.Value);
        }
    }
}
