using System;
using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class ChartTemperatureDataProvider : IChartTemperatureDataProvider {
        public List<TemperatureData> GenerateData() {
            List<TemperatureData> result = new List<TemperatureData> {
                new TemperatureData(new DateTime(2023, 9, 1), 52),
                new TemperatureData(new DateTime(2023, 9, 2), 57),
                new TemperatureData(new DateTime(2023, 9, 3), 58),
                new TemperatureData(new DateTime(2023, 9, 4), 56),
                new TemperatureData(new DateTime(2023, 9, 5), 59),
                new TemperatureData(new DateTime(2023, 9, 6), 59),
                new TemperatureData(new DateTime(2023, 9, 7), 56),
                new TemperatureData(new DateTime(2023, 9, 8), 62),
                new TemperatureData(new DateTime(2023, 9, 9), 57),
                new TemperatureData(new DateTime(2023, 9, 10), 54),
                new TemperatureData(new DateTime(2023, 9, 11), 52),
                new TemperatureData(new DateTime(2023, 9, 12), 58),
                new TemperatureData(new DateTime(2023, 9, 13), 53),
                new TemperatureData(new DateTime(2023, 9, 14), 54),
                new TemperatureData(new DateTime(2023, 9, 15), 57),
                new TemperatureData(new DateTime(2023, 9, 16), 61),
                new TemperatureData(new DateTime(2023, 9, 17), 58),
                new TemperatureData(new DateTime(2023, 9, 18), 63),
                new TemperatureData(new DateTime(2023, 9, 19), 64),
                new TemperatureData(new DateTime(2023, 9, 20), 52)
            };

            return result;
        }
    }
}
