using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class RentInfoDataService {
        protected readonly IRentInfoDataProvider _dataProvider;

        public RentInfoDataService(IRentInfoDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }

    }
}
