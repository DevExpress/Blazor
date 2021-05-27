using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class NwindDataService {
        protected readonly INwindDataProvider _dataProvider;

        public NwindDataService(INwindDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }
    }
}
