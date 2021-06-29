using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.Wasm.Server.DataProviders;

namespace BlazorDemo.DataProviders.Implementation {
    public class WeatherSummaryDataProvider : IWeatherSummaryDataProvider {
        List<DetailedWeatherSummary> summary = null;
        readonly IWeatherSummaryCsvFileContentProvider fileContentProvider;

        public WeatherSummaryDataProvider(IWeatherSummaryCsvFileContentProvider fileContentProvider) {
            this.fileContentProvider = fileContentProvider;
        }

        public async Task<IEnumerable<DetailedWeatherSummary>> GetDataAsync() {
            if(summary == null) {
                string fileContent = await fileContentProvider.GetFileContentAsync();
                summary = WeatherForecastCsvParser.Parse(fileContent);
            }
            return await Task.FromResult(summary);
        }
    }
}
