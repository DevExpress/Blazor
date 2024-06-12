using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartSpiderDataProvider {
        public List<SpiderPoint> GenerateData();
    }
}
