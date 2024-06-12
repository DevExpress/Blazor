using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartTemperatureDataProvider {
        public List<TemperatureData> GenerateData();
    }
}
