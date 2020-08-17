using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.SalesViewer;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    class SalesViewerDataProvider : RemoteDataProviderBase, ISalesViewerDataProvider {

        public Task<IEnumerable<Channel>> GetChannels(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetChannels);
        public Task<IEnumerable<City>> GetCities(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetCities);
        public Task<IEnumerable<Contact>> GetContacts(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetContacts);
        public Task<IEnumerable<Customer>> GetCustomers(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetCustomers);
        public Task<IEnumerable<Plant>> GetPlants(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetPlants);
        public Task<IEnumerable<Product>> GetProducts(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetProducts);
        public Task<IEnumerable<Region>> GetRegions(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetRegions);
        public Task<IEnumerable<Sale>> GetSales(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetSales);
        public Task<IEnumerable<Sector>> GetSectors(CancellationToken ct) => Loader.LoadRemoteEntities(this, GetSectors);

        public SalesViewerDataProvider(RemoteDataProviderLoader loader) : base(loader) {
        }
    }
}
