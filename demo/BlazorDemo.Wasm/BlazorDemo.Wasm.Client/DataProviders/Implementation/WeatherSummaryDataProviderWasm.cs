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

        public async Task<IEnumerable<DetailedWeatherSummary>> GetDataAsync(bool aggregateByMonth) {
            string fileContent = await httpClient.GetStringAsync("api/get-weather-summary");
            List<DetailedWeatherSummary> summary = WeatherForecastCsvParser.Parse(fileContent);
            if(aggregateByMonth)
                return await Task.FromResult(WeatherAggregator.Aggregate(summary));
            else
                return summary;
        }
    }
}
