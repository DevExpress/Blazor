using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IFinancialSeriesDataProvider {
        public Task<IEnumerable<BargainDataPoint>> Generate();
    }
}
