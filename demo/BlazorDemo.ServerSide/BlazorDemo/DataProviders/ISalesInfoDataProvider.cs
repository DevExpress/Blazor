using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("0FA3F7F9-ACDE-4B6C-9DAB-47589723818F")]
    public interface ISalesInfoDataProvider : IDataProvider {
        Task<IEnumerable<SaleInfo>> GetSalesAsync(CancellationToken ct = default);
        Task<IEnumerable<SaleInfo>> GetReducedSalesAsync(CancellationToken ct = default);
    }
}
