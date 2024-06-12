using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartContinuousDataProvider {
        public List<DataPoint> GenerateData();
    }
}
