using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class ChartAverageTemperatureDataProvider : IChartAverageTemperatureDataProvider {
        public List<AverageTemperatureData> GenerateData() {
            List<AverageTemperatureData> result = new List<AverageTemperatureData> {
                new AverageTemperatureData {
                    Month = "January",
                    AverageTemperature = 14.1,
                    AverageLowTemperature = 9.1,
                    AverageHighTemperature = 19.1,
                    AverageHumidity = 70
                },
                new AverageTemperatureData {
                    Month = "February",
                    AverageTemperature = 14.7,
                    AverageLowTemperature = 9.8,
                    AverageHighTemperature = 19.6,
                    AverageHumidity = 74
                },
                new AverageTemperatureData {
                    Month = "March",
                    AverageTemperature = 15.6,
                    AverageLowTemperature = 10.6,
                    AverageHighTemperature = 20.4,
                    AverageHumidity = 79
                },
                new AverageTemperatureData {
                    Month = "April",
                    AverageTemperature = 16.8,
                    AverageLowTemperature = 11.9,
                    AverageHighTemperature = 21.7,
                    AverageHumidity = 80
                },
                new AverageTemperatureData {
                    Month = "May",
                    AverageTemperature = 18.2,
                    AverageLowTemperature = 13.6,
                    AverageHighTemperature = 22.7,
                    AverageHumidity = 83
                },
                new AverageTemperatureData {
                    Month = "June",
                    AverageTemperature = 20.2,
                    AverageLowTemperature = 15.4,
                    AverageHighTemperature = 25,
                    AverageHumidity = 85
                },
                new AverageTemperatureData {
                    Month = "July",
                    AverageTemperature = 22.6,
                    AverageLowTemperature = 17.3,
                    AverageHighTemperature = 27.9,
                    AverageHumidity = 86
                },
                new AverageTemperatureData {
                    Month = "August",
                    AverageTemperature = 23,
                    AverageLowTemperature = 17.7,
                    AverageHighTemperature = 28.4,
                    AverageHumidity = 86
                },
                new AverageTemperatureData {
                    Month = "September",
                    AverageTemperature = 22.3,
                    AverageLowTemperature = 17,
                    AverageHighTemperature = 27.7,
                    AverageHumidity = 83
                },
                new AverageTemperatureData {
                    Month = "October",
                    AverageTemperature = 20.1,
                    AverageLowTemperature = 14.8,
                    AverageHighTemperature = 25.3,
                    AverageHumidity = 79
                },
                new AverageTemperatureData {
                    Month = "November",
                    AverageTemperature = 17.2,
                    AverageLowTemperature = 11.8,
                    AverageHighTemperature = 22.7,
                    AverageHumidity = 72
                },
                new AverageTemperatureData {
                    Month = "December",
                    AverageTemperature = 14.6,
                    AverageLowTemperature = 9.5,
                    AverageHighTemperature = 19.7,
                    AverageHumidity = 68
                }
            };

            return result;
        }
    }
}
