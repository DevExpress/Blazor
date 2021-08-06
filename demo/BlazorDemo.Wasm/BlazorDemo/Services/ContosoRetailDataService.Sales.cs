using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public partial class ContosoRetailDataService {
        public IQueryable<Sale> GetSales() {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetSales();
            /*EndHide*/
        }
    }
}
