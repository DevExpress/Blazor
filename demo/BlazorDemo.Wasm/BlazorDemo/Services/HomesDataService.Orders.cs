using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Homes;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class HomesDataService {
        public Task<IEnumerable<Order>> GetOrdersAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetOrdersAsync(ct);
            /*EndHide*/
        }
    }
}
