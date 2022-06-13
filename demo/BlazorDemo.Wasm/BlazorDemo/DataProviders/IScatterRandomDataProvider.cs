using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IScatterRandomDataProvider {
        public Task<IEnumerable<DataPoint>> GenerateCluster(int xPlus, int xMinus, int yPlus, int yMinus, int count, int randomSeek);
    }
}

