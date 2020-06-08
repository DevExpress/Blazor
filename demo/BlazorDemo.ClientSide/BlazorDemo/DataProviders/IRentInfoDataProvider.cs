using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("EC9EA76C-2166-4839-85E2-1B061B6EFBA2")]
    public interface IRentInfoDataProvider : IDataProvider {
        Task<IEnumerable<AreaRentInfo>> GetAreaRentInfoAsync(CancellationToken ct = default);
    }
}