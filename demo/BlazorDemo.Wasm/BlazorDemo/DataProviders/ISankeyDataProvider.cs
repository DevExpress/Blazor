using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ISankeyDataProvider {
        public List<SankeyDataPoint> GenerateData();
    }
}
