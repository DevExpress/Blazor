using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class IssuesDataService {
        public Task<IEnumerable<Project>> GetProjectsAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetProjectsAsync(ct);
            /*EndHide*/
        }
    }
}
