using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class WeatherSummaryDataProviderWasm : IWeatherSummaryDataProvider {
        HttpClient httpClient;

        public WeatherSummaryDataProviderWasm(HttpClient httpClient) {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<DetailedWeatherSummary>> GetDataAsync() {
            string fileContent = await httpClient.GetStringAsync("api/get-weather-summary");
            return WeatherForecastCsvParser.Parse(fileContent);
        }
    }
}
