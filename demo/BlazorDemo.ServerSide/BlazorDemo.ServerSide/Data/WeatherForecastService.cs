using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Services
{
    public class WeatherForecastService
    {
        private static string[] Summaries = new[]
        {
            "Hot", "Warm", "Cold", "Freezing"
        };

        private List<WeatherForecast> CreateForecast()
        {
            var rng = new Random();
            DateTime startDate = DateTime.Now;
            return Enumerable.Range(1, 15).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
        }
        private List<WeatherForecast> CreateDetailedForecast() {
            var rng = new Random();
            DateTime startDate = DateTime.Now.Date;
            return Enumerable.Range(1, 15).SelectMany(day => { 
                var dayDate = startDate.AddDays(day);
                int avgTemp = rng.Next(-20, 55);
                int minTemp = Math.Max(-20, avgTemp - 10);
                int maxTemp = Math.Min(55, avgTemp + 10);
                return Enumerable.Range(0, 24).Select(hour => new WeatherForecast
                {
                    Date = dayDate.AddHours(hour),
                    TemperatureC = rng.Next(minTemp, maxTemp),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                });
            }).ToList();
        }

        private List<WeatherForecast> Forecasts { get; set; }
        private List<WeatherForecast> DetailedForecast { get; set; }
        public WeatherForecastService()
        {
            Forecasts = CreateForecast();
            DetailedForecast = CreateDetailedForecast();
        }
        public Task<WeatherForecast[]> GetForecastAsync()
        {
            return Task.FromResult(Forecasts.ToArray());
        }
        public Task<WeatherForecast[]> GetDetailedForecastAsync() {
            return Task.FromResult(DetailedForecast.ToArray());
        }
        public Task<string[]> GetSummariesAsync()
        {
            return Task.FromResult(Summaries);
        }
        WeatherForecast[] InsertInternal(Dictionary<string, object> newValue)
        {
            var dataItem = new WeatherForecast();
            Update(dataItem, newValue);
            Forecasts.Insert(0, dataItem);
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Insert(Dictionary<string, object> newValue)
        {
            return Task.FromResult(InsertInternal(newValue));
        }
        WeatherForecast[] RemoveInternal(WeatherForecast dataItem)
        {
            Forecasts.Remove(dataItem);
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Remove(WeatherForecast dataItem)
        {
            return Task.FromResult(RemoveInternal(dataItem));
        }
        WeatherForecast[] UpdateInternal(WeatherForecast dataItem, Dictionary<string, object> newValue)
        {
            foreach (var field in newValue.Keys)
            {
                switch (field)
                {
                    case "Date":
                        dataItem.Date = (DateTime)newValue[field];
                        break;
                    case "Summary":
                        dataItem.Summary = (string)newValue[field];
                        break;
                    case "TemperatureC":
                        int intValue = 0;
                        if (Int32.TryParse((string)newValue[field], out intValue))
                        {
                            dataItem.TemperatureC = intValue;
                        }
                        break;
                }
            }
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Update(WeatherForecast dataItem, Dictionary<string, object> newValue)
        {
            return Task.FromResult(UpdateInternal(dataItem, newValue));
        }
    }
}