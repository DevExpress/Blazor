using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IGlobalTemperatureIndexDataProvider {
        public Task<IEnumerable<GlobalTemperatureIndexInfo>> GetDataAsync();
    }
}
