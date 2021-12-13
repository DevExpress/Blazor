using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.Wasm.Server.DataProviders;

namespace BlazorDemo.DataProviders.Implementation {
    public class GlobalTemperatureIndexDataProvider : IGlobalTemperatureIndexDataProvider {
        List<GlobalTemperatureIndexInfo> cachedList = null;
        readonly IGlobalTemperatureIndexFileContentProvider fileContentProvider;

        public GlobalTemperatureIndexDataProvider(IGlobalTemperatureIndexFileContentProvider fileContentProvider) {
            this.fileContentProvider = fileContentProvider;
        }

        public async Task<IEnumerable<GlobalTemperatureIndexInfo>> GetDataAsync() {
            if(cachedList == null) {
                string fileContent = await fileContentProvider.GetFileContentAsync();
                cachedList = GlobalTemperatureIndexCsvParser.Parse(fileContent);
            }
            return await Task.FromResult(cachedList);
        }
    }
}
