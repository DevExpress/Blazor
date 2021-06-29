using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorDemo.Wasm.Server.DataProviders {
    public interface IWeatherSummaryCsvFileContentProvider {
        public Task<string> GetFileContentAsync();
    }
    public class WeatherSummaryCsvFileContentProvider : IWeatherSummaryCsvFileContentProvider {
        string cachedContent;

        public async Task<string> GetFileContentAsync() {
            if(cachedContent == null) {
                string pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "AnnualWeather.csv");
                cachedContent = await File.ReadAllTextAsync(pathToDataFile);
            }
            return cachedContent;
        }
    }
}
