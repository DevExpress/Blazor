using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class IssuesDataService {
        public Task<IEnumerable<User>> GetUsersAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetUsersAsync(ct);
            /*EndHide*/
        }
    }
}
