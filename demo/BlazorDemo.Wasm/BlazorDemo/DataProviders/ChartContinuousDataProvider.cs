using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class ChartContinuousDataProvider : IChartContinuousDataProvider {
        public List<DataPoint> GenerateData() {
            return new List<DataPoint>() {
                new DataPoint(0, 0),
                new DataPoint(30, 1.7),
                new DataPoint(45, 0),
                new DataPoint(60, 1.7),
                new DataPoint(90, 0),
                new DataPoint(120, 1.7),
                new DataPoint(135, 0),
                new DataPoint(150, 1.7),
                new DataPoint(180, 0),
                new DataPoint(210, 1.7),
                new DataPoint(225, 0),
                new DataPoint(240, 1.7),
                new DataPoint(270, 0),
                new DataPoint(300, 1.7),
                new DataPoint(315, 0),
                new DataPoint(330, 1.7),
                new DataPoint(360, 0),
            };
        }
    }
}
