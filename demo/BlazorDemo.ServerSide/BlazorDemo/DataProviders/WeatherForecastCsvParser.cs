using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BlazorDemo.Data {
    public static class WeatherForecastCsvParser {
        public static List<DetailedWeatherSummary> Parse(string fileContent) {
            var list = new List<DetailedWeatherSummary>();
            using(StringReader reader = new StringReader(fileContent)) {
                string line;
                reader.ReadLine(); //skip headers
                while((line = reader.ReadLine()) != null) {
                    string[] arr = line.Split(',');
                    list.Add(new DetailedWeatherSummary() {
                        City = arr[1],
                        MinTemperatureF = double.Parse(arr[5], CultureInfo.InvariantCulture),
                        MaxTemperatureF = double.Parse(arr[4], CultureInfo.InvariantCulture),
                        PrecipitationInch = double.Parse(arr[6], CultureInfo.InvariantCulture),
                        Date = DateTime.ParseExact(arr[2], "M/d/yyyy", CultureInfo.InvariantCulture),
                        AverageTemperatureF = double.Parse(arr[3], CultureInfo.InvariantCulture)
                    });
                }
            }
            return list;
        }
    }
}
