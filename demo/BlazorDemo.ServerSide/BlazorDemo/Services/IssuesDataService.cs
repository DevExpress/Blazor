using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Issues;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class IssuesDataService {
        readonly IIssuesDataProvider _dataProvider;

        public IssuesDataService(IIssuesDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
    }
}
