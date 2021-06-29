using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public partial class ContosoRetailDataService {
        public Task<IEnumerable<Sale>> GetSalesAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetSalesAsync(ct);
            /*EndHide*/
        }
    }
}
