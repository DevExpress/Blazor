using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorDemo.Wasm.DataProviders.Implementation {
    public class UsdJpyDataProviderWasm : ICurrencyExchangeDataProvider {
#pragma warning disable DX0006
        HttpClient httpClient;

        public UsdJpyDataProviderWasm(HttpClient httpClient) {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<DatePricePoint>> GetDataAsync() {
            string fileContent = await httpClient.GetStringAsync("api/get-usdjpy-exchange-data");
            return CurrencyExchangeCsvParser.Parse(fileContent);
        }
#pragma warning restore DX0006
    }
}
