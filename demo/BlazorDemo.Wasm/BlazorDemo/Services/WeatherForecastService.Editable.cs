using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.Services {
    public partial class WeatherForecastService {
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
