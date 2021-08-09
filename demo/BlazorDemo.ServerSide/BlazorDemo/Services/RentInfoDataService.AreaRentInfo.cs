using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public partial class RentInfoDataService {
        public IQueryable<AreaRentInfo> GetAreaRentInfo() {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetAreaRentInfo();
            /*EndHide*/
        }
    }
}
