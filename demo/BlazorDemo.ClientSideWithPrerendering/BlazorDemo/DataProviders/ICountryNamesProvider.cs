using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("6DEEF83B-3423-4E23-A1CF-1366CC9AC68C")]
    public interface ICountryNamesProvider : IDataProvider {
        public Task<IEnumerable<Country>> LoadAsync(CancellationToken ct = default);
    }
}
