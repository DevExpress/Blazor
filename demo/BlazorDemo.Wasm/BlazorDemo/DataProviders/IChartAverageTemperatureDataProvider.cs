using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartAverageTemperatureDataProvider {
        public List<AverageTemperatureData> GenerateData();
    }
}
