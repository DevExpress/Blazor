using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("2E94E79A-A3A0-4207-A309-841F9460FD16")]
    public interface IFlatProductsProvider : IDataProvider {
        Task<IEnumerable<ProductFlat>> LoadAsync(CancellationToken ct = default);
        Task Add(ProductFlat item);
        Task Remove(ProductFlat item);
    }
}