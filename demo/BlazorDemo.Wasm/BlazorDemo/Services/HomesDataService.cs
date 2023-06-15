using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class HomesDataService {
        protected readonly IHomesDataProvider _dataProvider;

        public HomesDataService(IHomesDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
    }
}
