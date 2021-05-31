using System;
using System.IO;
using System.Threading.Tasks;

namespace BlazorDemo.Wasm.Server.DataProviders {
    public interface IUsdJpyCsvFileContentProvider {
        public Task<string> GetFileContentAsync();
    }

    public class UsdJpyCsvFileContentProvider : IUsdJpyCsvFileContentProvider {
        string cachedContent;

        public async Task<string> GetFileContentAsync() {
            if(cachedContent == null) {
                string pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "USDJPY.csv");
                cachedContent = await File.ReadAllTextAsync(pathToDataFile);
            }
            return cachedContent;
        }
    }
}
