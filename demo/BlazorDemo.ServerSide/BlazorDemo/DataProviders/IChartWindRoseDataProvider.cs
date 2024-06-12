using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartWindRoseDataProvider {
        public Dictionary<string, List<WindRosePoint>> GenerateData();
    }
}
