using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IPopulationCorrelationDataProvider {
        public Task<IEnumerable<PopulationCorrelationDataPoint>> GetData();
    }
}

