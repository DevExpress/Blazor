using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Worldcities;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class WorldcitiesDataService {
        public Task<IEnumerable<City>> GetCitiesAsync(CancellationToken ct = default) {
            // Return your data here
            /*BeginHide*/
            return _dataProvider.GetCitiesAsync(ct);
            /*EndHide*/
        }
    }
}
