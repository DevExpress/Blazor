using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorDemo.Wasm.Server.DataProviders {
    public interface IGlobalTemperatureIndexFileContentProvider {
        public Task<string> GetFileContentAsync();
    }

    public class GlobalTemperatureIndexFileContentProvider : IGlobalTemperatureIndexFileContentProvider {
        string cachedContent;

        public async Task<string> GetFileContentAsync() {
            if(cachedContent == null) {
                string pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "GlobalTemperatureIndex.csv");
                cachedContent = await File.ReadAllTextAsync(pathToDataFile);
            }
            return cachedContent;
        }
    }
}
