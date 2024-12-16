using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data.Sales;

namespace BlazorDemo.DataProviders {
    public interface ISalesDataProvider {
        public Task<IList<SaleEntity>> GetDataAsync(int recordsCount);
    }
}
