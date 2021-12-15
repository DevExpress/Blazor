using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class GlobalTemperatureIndexDataProviderWasm : IGlobalTemperatureIndexDataProvider {
        HttpClient httpClient;

        public GlobalTemperatureIndexDataProviderWasm(HttpClient httpClient) {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<GlobalTemperatureIndexInfo>> GetDataAsync() {
            string fileContent = await httpClient.GetStringAsync("api/get-global-temperature-index");
            return GlobalTemperatureIndexCsvParser.Parse(fileContent);
        }
    }
}
