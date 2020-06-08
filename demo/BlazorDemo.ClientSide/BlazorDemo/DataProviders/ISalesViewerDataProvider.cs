using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.SalesViewer;

namespace BlazorDemo.DataProviders {
    [Guid("072B5FF7-9340-4971-A53E-358ECDB0D8CF")]
    public interface ISalesViewerDataProvider : IDataProvider {
        Task<IEnumerable<Channel>> GetChannels(CancellationToken ct = default);
        Task<IEnumerable<City>> GetCities(CancellationToken ct = default);
        Task<IEnumerable<Contact>> GetContacts(CancellationToken ct = default);
        Task<IEnumerable<Customer>> GetCustomers(CancellationToken ct = default);
        Task<IEnumerable<Plant>> GetPlants(CancellationToken ct = default);
        Task<IEnumerable<Product>> GetProducts(CancellationToken ct = default);
        Task<IEnumerable<Region>> GetRegions(CancellationToken ct = default);
        Task<IEnumerable<Sale>> GetSales(CancellationToken ct = default);
        Task<IEnumerable<Sector>> GetSectors(CancellationToken ct = default);
    }
}