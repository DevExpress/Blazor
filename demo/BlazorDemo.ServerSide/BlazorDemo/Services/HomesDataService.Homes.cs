using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Homes;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class HomesDataService {
        public Task<IEnumerable<Home>> GetHomesAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetHomesAsync(ct);
            /*EndHide*/
        }
    }
}
