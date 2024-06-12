using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class ChartWindRoseDataProvider : IChartWindRoseDataProvider {
        public Dictionary<string, List<WindRosePoint>> GenerateData() {
            return new Dictionary<string, List<WindRosePoint>>() {
                {
                    "September", new List<WindRosePoint>() {
                        new WindRosePoint("N", 0.7, 1.7, 2, 1, 0, 0, 0, 0),
                        new WindRosePoint("NNE", 0.1, 0.6, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("NE", 0.3, 0.8, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("ENE", 0.3, 0.7, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("E", 0.7, 3.2, 3, 0, 0, 0, 0, 0),
                        new WindRosePoint("ESE", 0.8, 1.5, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("SE", 0.3, 1.3, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("SSE", 0.1, 2.4, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("S", 1.1, 4.2, 2, 0, 0, 0, 0, 0),
                        new WindRosePoint("SSW", 0.6, 3.6, 3, 0, 0, 0, 0, 0),
                        new WindRosePoint("SW", 0.8, 2.5, 5, 1, 0, 0, 0, 0),
                        new WindRosePoint("WSW", 0.3, 2.6, 3, 0, 0, 0, 0, 0),
                        new WindRosePoint("W", 0.6, 1.7, 3, 0, 0, 0, 0, 0),
                        new WindRosePoint("WNW", 0.7, 2.5, 3, 0, 0, 0, 0, 0),
                        new WindRosePoint("NW", 1, 3.2, 3, 1, 0, 0, 0, 0),
                        new WindRosePoint("NNW", 0.6, 3.8, 4, 2, 0, 0, 0, 0)
                    }
                }, {
                    "October", new List<WindRosePoint>() {
                        new WindRosePoint("N", 0.6, 1.8, 2, 1, 0, 1, 0, 0),
                        new WindRosePoint("NNE", 0.3, 1.2, 1, 0, 1, 0, 0, 0),
                        new WindRosePoint("NE", 0.3, 2.4, 2, 1, 1, 0, 0, 0),
                        new WindRosePoint("ENE", 1, 2.2, 1, 0, 0, 0, 0, 0),
                        new WindRosePoint("E", 0.6, 4.9, 2, 0, 0, 0, 0, 0),
                        new WindRosePoint("ESE", 0.1, 0.6, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("SE", 0.1, 0.3, 1, 1, 0, 0, 0, 0),
                        new WindRosePoint("SSE", 0.4, 0.7, 1, 0, 0, 0, 0, 0),
                        new WindRosePoint("S", 0, 3.1, 3, 1, 0, 0, 0, 0),
                        new WindRosePoint("SSW", 0.6, 1.8, 4, 1, 0, 0, 0, 0),
                        new WindRosePoint("SW", 0.7, 1.8, 2, 1, 0, 0, 0, 0),
                        new WindRosePoint("WSW", 0.3, 2.5, 5, 1, 0, 0, 0, 0),
                        new WindRosePoint("W", 0, 2.8, 6, 2, 0, 0, 0, 0),
                        new WindRosePoint("WNW", 0.3, 1.5, 4, 1, 0, 0, 0, 0),
                        new WindRosePoint("NW", 0.1, 2.7, 2, 1, 0, 0, 0, 0),
                        new WindRosePoint("NNW", 0.3, 1.5, 1, 1, 0, 0, 0, 0)
                    }
                }, {
                    "November", new List<WindRosePoint>() {
                        new WindRosePoint("N", 0.7, 3, 8, 2, 0, 0, 0, 0),
                        new WindRosePoint("NNE", 0.4, 1.6, 2, 1, 0, 0, 0, 0),
                        new WindRosePoint("NE", 0.5, 3.4, 8, 2, 0, 0, 0, 0),
                        new WindRosePoint("ENE", 0.3, 4.1, 2, 0, 0, 0, 0, 0),
                        new WindRosePoint("E", 1.2, 1.8, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("ESE", 0.7, 0.3, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("SE", 0.1, 0.3, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("SSE", 0.3, 0.4, 1, 0, 0, 0, 0, 0),
                        new WindRosePoint("S", 0.4, 0.8, 1, 0, 0, 0, 0, 0),
                        new WindRosePoint("SSW", 0.4, 1.5, 0, 0, 0, 0, 0, 0),
                        new WindRosePoint("SW", 0.8, 0.1, 1, 0, 0, 0, 0, 0),
                        new WindRosePoint("WSW", 0, 1.5, 2, 1, 0, 0, 0, 0),
                        new WindRosePoint("W", 0.3, 1, 6, 3, 0, 0, 0, 0),
                        new WindRosePoint("WNW", 0.3, 1.2, 3, 1, 1, 0, 0, 0),
                        new WindRosePoint("NW", 0.3, 0.7, 5, 2, 0, 0, 0, 0),
                        new WindRosePoint("NNW", 0.1, 2.5, 2, 2, 1, 0, 0, 0)
                    }
                }
            };
        }
    }
}
