using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartDiscreteDataProvider {
        public List<DiscretePoint> GenerateData();
    }
}
