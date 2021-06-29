using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public partial class RentInfoDataService {
        public Task<IEnumerable<AreaRentInfo>> GetAreaRentInfoAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetAreaRentInfoAsync(ct);
            /*EndHide*/
        }
    }
}
