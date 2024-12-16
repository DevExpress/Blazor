using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation;

public class VehiclesXmlFileContentProvider : IVehiclesXmlFileContentProvider {
    string _cachedRawContent;

    public async Task<IEnumerable<VehiclesData.TrademarkItem>> GetDataAsync(int recordsCount, int numberOfDaysToDisplay) {
        if(_cachedRawContent == null)
            await GetFileContentAsync();
        return (await VehiclesData.InitOrdersData(_cachedRawContent, recordsCount, numberOfDaysToDisplay)).TrademarkItems;
    }

    public async Task<string> GetFileContentAsync() {
        var pathToDataFile = Path.Combine(AppContext.BaseDirectory, "DataSources", "Vehicles.xml");
        _cachedRawContent = await File.ReadAllTextAsync(pathToDataFile);
        return _cachedRawContent;
    }
}
