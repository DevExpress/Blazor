using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.Wasm.Server.DataProviders;
using System.Linq;
using System;

namespace BlazorDemo.DataProviders.Implementation {
    public class WeatherSummaryDataProvider : IWeatherSummaryDataProvider {
        List<DetailedWeatherSummary> summary = null;
        readonly IWeatherSummaryCsvFileContentProvider fileContentProvider;

        public WeatherSummaryDataProvider(IWeatherSummaryCsvFileContentProvider fileContentProvider) {
            this.fileContentProvider = fileContentProvider;
        }

        public async Task<IEnumerable<DetailedWeatherSummary>> GetDataAsync(bool aggregateByMonth = false) {
            if(summary == null) {
                string fileContent = await fileContentProvider.GetFileContentAsync();
                summary = WeatherForecastCsvParser.Parse(fileContent);
            }
            if(aggregateByMonth) 
                return await Task.FromResult(WeatherAggregator.Aggregate(summary));
            else
                return await Task.FromResult(summary);
        }
    }
}
