using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IHistogramDataProvider {
        public Task<IEnumerable<DataPoint>> GetNormalDistribution();
        public Task<IEnumerable<DataPoint>> GenerateData();
    }
}
