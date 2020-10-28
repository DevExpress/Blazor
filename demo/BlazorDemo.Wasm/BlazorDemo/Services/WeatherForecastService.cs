using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public class WeatherForecastService {
        Tuple<int, int>[] temperatureStatistic = new Tuple<int, int>[] {
            Tuple.Create(-15, -1),
            Tuple.Create(-12, -2),
            Tuple.Create(-6, 8),
            Tuple.Create(4, 14),
            Tuple.Create(11, 21),
            Tuple.Create(13, 23),
            Tuple.Create(18, 32),
            Tuple.Create(16, 26),
            Tuple.Create(10, 18),
            Tuple.Create(1, 11),
            Tuple.Create(-4, 6),
            Tuple.Create(-13, 1)
        };

        Tuple<int, string>[] ConditionsForForecast = new Tuple<int, string>[] {
            Tuple.Create( 28 , "Hot"),
            Tuple.Create( 14 , "Warm"),
            Tuple.Create( -9 , "Cold"),
            Tuple.Create( -80 , "Freezing")
        };

        private static string[] CloudCover = new[] {
            "Sunny", "Partly cloudy", "Cloudy", "Storm"
        };

        private List<WeatherForecast> CreateForecast() {
            var rng = RandomWrapperFactory.Create();
            DateTime startDate = DateTime.Now;

            int min = 0;
            int max = 0;
            int? temperatureC = null;

            return Enumerable.Range(1, 15).Select(index => {
                var day = startDate.AddDays(index);
                if(day.Month - startDate.AddDays(index - 1).Month != 0 || temperatureC == null) {
                    min = temperatureStatistic[day.Month - 1].Item1;
                    max = temperatureStatistic[day.Month - 1].Item2;
                    temperatureC = rng.Next(min, max);
                } else {
                    temperatureC = temperatureC + rng.Next(-3, 3);
                    temperatureC = Math.Max(temperatureC.Value, min);
                    temperatureC = Math.Min(temperatureC.Value, max);
                }
                int weatherTypes = rng.NextDouble() < 0.5 ? 0 : (rng.NextDouble() < 0.5 ? 1 : rng.NextDouble() < 0.5 ? 2 : 3);
                double feelTemper = temperatureC.Value - (weatherTypes - 1) * 3;
                return new WeatherForecast {
                    Date = day,
                    TemperatureC = temperatureC.Value,
                    Precipitation = rng.NextDouble() < weatherTypes * 0.3,
                    CloudCover = CloudCover[weatherTypes],
                    Forecast = ConditionsForForecast.First(c => c.Item1 <= feelTemper).Item2
                };
            }).ToList();
        }
        private List<WeatherForecast> CreateDetailedForecast() {
            var rng = RandomWrapperFactory.Create();
            DateTime startDate = DateTime.Now.Date;
            return Enumerable.Range(1, 15).SelectMany(day => {
                var dayDate = startDate.AddDays(day);
                int avgTemp = rng.Next(-20, 55);
                int minTemp = Math.Max(-20, avgTemp - 10);
                int maxTemp = Math.Min(55, avgTemp + 10);
                return Enumerable.Range(0, 24).Select(hour => new WeatherForecast {
                    Date = dayDate.AddHours(hour),
                    TemperatureC = rng.Next(minTemp, maxTemp),
                    Forecast = ConditionsForForecast[rng.Next(ConditionsForForecast.Length)].Item2,
                    CloudCover = CloudCover[rng.Next(CloudCover.Length)],
                    Precipitation = rng.Next(100) < 30
                });
            }).ToList();
        }

        private List<WeatherForecast> Forecasts { get; set; }
        private List<WeatherForecast> DetailedForecast { get; set; }
        public WeatherForecastService() {
            Forecasts = CreateForecast();
            DetailedForecast = CreateDetailedForecast();
        }
        public Task<IEnumerable<WeatherForecast>> GetForecastAsync(CancellationToken ct = default) {
            return Task.FromResult(Forecasts.AsEnumerable());
        }
        public IEnumerable<WeatherForecast> GetForecast() {
            return Forecasts;
        }
        public Task<WeatherForecast[]> GetDetailedForecastAsync(CancellationToken ct = default) {
            return Task.FromResult(DetailedForecast.ToArray());
        }
        public Task<string[]> GetSummariesAsync(CancellationToken ct = default) {
            return Task.FromResult(ConditionsForForecast.Select(v => v.Item2).ToArray());
        }
        public Task<IEnumerable<string>> GetCloudCoverAsync(CancellationToken ct = default) {
            return Task.FromResult(CloudCover.AsEnumerable());
        }
        WeatherForecast[] InsertInternal(IDictionary<string, object> newValue) {
            var dataItem = new WeatherForecast();
            Update(dataItem, newValue);
            Forecasts.Insert(0, dataItem);
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Insert(IDictionary<string, object> newValue) {
            return Task.FromResult(InsertInternal(newValue));
        }
        WeatherForecast[] RemoveInternal(WeatherForecast dataItem) {
            Forecasts.Remove(dataItem);
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Remove(WeatherForecast dataItem) {
            return Task.FromResult(RemoveInternal(dataItem));
        }
        WeatherForecast[] UpdateInternal(WeatherForecast dataItem, IDictionary<string, object> newValue) {
            foreach(var field in newValue.Keys) {
                switch(field) {
                    case nameof(dataItem.Date):
                        dataItem.Date = (DateTime)newValue[field];
                        break;
                    case nameof(dataItem.Forecast):
                        dataItem.Forecast = (string)newValue[field];
                        break;
                    case nameof(dataItem.TemperatureC):
                        dataItem.TemperatureC = (int)newValue[field];
                        break;
                    case nameof(dataItem.Precipitation):
                        dataItem.Precipitation = (bool)newValue[field];
                        break;
                    case nameof(dataItem.CloudCover):
                        dataItem.CloudCover = (string)newValue[field];
                        break;
                }
            }
            return Forecasts.ToArray();
        }
        public Task<WeatherForecast[]> Update(WeatherForecast dataItem, IDictionary<string, object> newValue) {
            return Task.FromResult(UpdateInternal(dataItem, newValue));
        }
    }
}
