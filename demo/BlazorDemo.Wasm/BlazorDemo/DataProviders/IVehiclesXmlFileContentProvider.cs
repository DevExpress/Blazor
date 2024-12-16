using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IVehiclesXmlFileContentProvider {
        public Task<IEnumerable<VehiclesData.TrademarkItem>> GetDataAsync(int recordsCount, int numberOfDaysToDisplay);
        public Task<string> GetFileContentAsync();
    }
}
