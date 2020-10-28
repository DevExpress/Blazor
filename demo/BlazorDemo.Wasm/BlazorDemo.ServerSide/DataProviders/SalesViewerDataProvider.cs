using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.SalesViewer;

namespace BlazorDemo.DataProviders.Implementation {
    class SalesViewerDataProvider : DataProviderBase, ISalesViewerDataProvider {
        protected Lazy<SalesViewerDataGenerator> DataGenerator { get; }
        protected Lazy<Task> DataGenerated { get; }
        protected SalesViewerContext DataContext { get; }

        public SalesViewerDataProvider() {
            DataContext = new SalesViewerContext();
            DataGenerator = new Lazy<SalesViewerDataGenerator>(CreateGenerator);
            DataGenerated = new Lazy<Task>(() => GenerateData());
        }

        protected virtual SalesViewerDataGenerator CreateGenerator() {
            return new SalesViewerDataGenerator(DataContext);
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
        public Task<IEnumerable<Channel>> GetChannels(CancellationToken ct) => GetDataTable(d => d.Channels);
        public Task<IEnumerable<City>> GetCities(CancellationToken ct) => GetDataTable(d => d.Cities);
        public Task<IEnumerable<Contact>> GetContacts(CancellationToken ct) => GetDataTable(d => d.Contacts);
        public Task<IEnumerable<Customer>> GetCustomers(CancellationToken ct) => GetDataTable(d => d.Customers);
        public Task<IEnumerable<Plant>> GetPlants(CancellationToken ct) => GetDataTable(d => d.Plants);
        public Task<IEnumerable<Product>> GetProducts(CancellationToken ct) => GetDataTable(d => d.Products);
        public Task<IEnumerable<Region>> GetRegions(CancellationToken ct) => GetDataTable(d => d.Regions);
        public Task<IEnumerable<Sale>> GetSales(CancellationToken ct) => GetDataTable(d => d.Sales);
        public Task<IEnumerable<Sector>> GetSectors(CancellationToken ct) => GetDataTable(d => d.Sectors);
    }
}
