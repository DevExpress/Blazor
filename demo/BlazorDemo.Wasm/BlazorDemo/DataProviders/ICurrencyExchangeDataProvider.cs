using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ICurrencyExchangeDataProvider {
        public Task<IEnumerable<BargainDataPoint>> GetDataAsync();
    }
}
