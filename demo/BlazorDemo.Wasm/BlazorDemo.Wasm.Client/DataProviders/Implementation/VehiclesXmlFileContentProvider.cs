using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorDemo.Data;
using BlazorDemo.DataProviders;
using BlazorDemo.Wasm.DataProviders.TransportInfrastructure;

namespace BlazorDemo.Wasm.DataProviders.Implementation;

public class VehiclesXmlFileContentProviderWasm : IVehiclesXmlFileContentProvider {
#pragma warning disable DX0006
    string _cachedRawContent;
    readonly HttpClient httpClient;

    public VehiclesXmlFileContentProviderWasm(HttpClient httpClient) {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<VehiclesData.TrademarkItem>> GetDataAsync(int recordsCount, int numberOfDaysToDisplay) {
        if(_cachedRawContent == null)
            await GetFileContentAsync();
        return (await VehiclesData.InitOrdersData(_cachedRawContent, recordsCount, numberOfDaysToDisplay)).TrademarkItems;
    }

    public async Task<string> GetFileContentAsync() {
        _cachedRawContent = await httpClient.GetStringAsync("api/get-vehicles-sales-data");
        return _cachedRawContent;
    }
#pragma warning restore DX0006
}
