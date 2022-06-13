using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {
    public class WeatherAggregator {
        public static List<DetailedWeatherSummary> Aggregate(List<DetailedWeatherSummary> summary) {
            List<DetailedWeatherSummary> list = new();
            int currentMonth = summary[0].Date.Month;
            double min = summary[0].MinTemperatureF;
            double max = summary[0].MaxTemperatureF;
            var filteredSummary = summary.Where(s => s.City == "HILO");
            foreach(DetailedWeatherSummary daySammary in filteredSummary) {
                if(daySammary.Date.Month == currentMonth) {
                    if(daySammary.MinTemperatureF < min)
                        min = daySammary.MinTemperatureF;
                    if(daySammary.MaxTemperatureF > max)
                        max = daySammary.MaxTemperatureF;
                } else {
                    list.Add(new DetailedWeatherSummary() { City = "HILO", Date = new DateTime(2020, currentMonth, 1), MaxTemperatureF = max, MinTemperatureF = min });
                    currentMonth = daySammary.Date.Month;
                    min = daySammary.MinTemperatureF;
                    max = daySammary.MaxTemperatureF;
                }
            }
            list.Add(new DetailedWeatherSummary() { City = "HILO", Date = new DateTime(2020, currentMonth, 1), MaxTemperatureF = max, MinTemperatureF = min });
            return list;
        }
    }
}
