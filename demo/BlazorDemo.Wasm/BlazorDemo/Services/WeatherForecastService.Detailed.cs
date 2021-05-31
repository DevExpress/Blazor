using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public partial class WeatherForecastService {
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

        private List<WeatherForecast> _detailedForecast;
        protected List<WeatherForecast> DetailedForecast {
            get {
                if(_detailedForecast == null)
                    _detailedForecast = CreateDetailedForecast();
                return _detailedForecast;
            }
        }

        public Task<WeatherForecast[]> GetDetailedForecastAsync(CancellationToken ct = default) {
            return Task.FromResult(DetailedForecast.ToArray());
        }
    }
}
