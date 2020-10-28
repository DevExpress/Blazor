using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    class RentInfoDataService {
        readonly IRentInfoDataProvider _dataProvider;

        public RentInfoDataService(IRentInfoDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
        public Task<IEnumerable<AreaRentInfo>> GetQueryableAreaRentInfo(CancellationToken ct) {
            return _dataProvider.GetAreaRentInfoAsync(ct);
        }
    }
}
