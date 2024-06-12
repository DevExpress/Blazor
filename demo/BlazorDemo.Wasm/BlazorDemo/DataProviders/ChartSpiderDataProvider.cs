using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class ChartSpiderDataProvider : IChartSpiderDataProvider {
        public List<SpiderPoint> GenerateData() {
            return new List<SpiderPoint>() {
                new SpiderPoint("USA", 4.21, 6.22, 0.8, 7.47),
                new SpiderPoint("China", 3.33, 8.65, 1.06, 5),
                new SpiderPoint("Turkey", 2.6, 4.25, 0.78, 1.71),
                new SpiderPoint("Italy", 2.2, 7.78, 0.52, 2.39),
                new SpiderPoint("India", 2.16, 2.26, 3.09, 6.26),
            };
        }
    }
}
