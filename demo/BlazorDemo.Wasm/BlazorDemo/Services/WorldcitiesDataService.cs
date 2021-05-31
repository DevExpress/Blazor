using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Worldcities;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class WorldcitiesDataService {
        readonly IWorldcitiesDataProvider _dataProvider;

        public WorldcitiesDataService(IWorldcitiesDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
    }
}
