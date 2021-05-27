using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    class RentInfoDataService {
        /*BeginHide*/
        readonly IRentInfoDataProvider _dataProvider;

        public RentInfoDataService(IRentInfoDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
        /*EndHide*/

        public Task<IEnumerable<AreaRentInfo>> GetQueryableAreaRentInfo(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetAreaRentInfoAsync(ct);
            /*EndHide*/
        }
    }
}
