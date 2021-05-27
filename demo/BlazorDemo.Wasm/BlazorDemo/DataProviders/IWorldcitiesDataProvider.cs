using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Worldcities;

namespace BlazorDemo.DataProviders {
    [Guid("2ABC9738-8198-4B66-8666-F3769F072537")]
    public interface IWorldcitiesDataProvider : IDataProvider {
        Task<IEnumerable<Country>> GetCountriesAsync(CancellationToken ct = default);
        Task<IEnumerable<City>> GetCitiesAsync(CancellationToken ct = default);
    }
}
