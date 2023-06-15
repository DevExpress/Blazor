using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    [Guid("1242C59D-E36D-4793-A5E4-B211DB9D1101")]
    public interface IExperimentResultDataProvider : IDataProvider {
        public Task<IEnumerable<DataPoint>> GetResultAsync(CancellationToken ct = default);
    }
}
