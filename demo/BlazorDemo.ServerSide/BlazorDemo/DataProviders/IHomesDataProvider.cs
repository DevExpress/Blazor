using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Homes;

namespace BlazorDemo.DataProviders {
    [Guid("27E26A60-4BD1-4C45-BF08-E3B5706C88E8")]
    public interface IHomesDataProvider : IDataProvider {
        Task<IEnumerable<Home>> GetHomesAsync(CancellationToken ct = default);

        Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken ct = default);

        Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default);
    }
}
