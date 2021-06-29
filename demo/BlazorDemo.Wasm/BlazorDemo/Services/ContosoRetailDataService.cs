using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorDemo.Data.Northwind;
using BlazorDemo.DataProviders;

namespace BlazorDemo.Services {
    public partial class ContosoRetailDataService {
        protected readonly IContosoRetailDataProvider _dataProvider;

        public ContosoRetailDataService(IContosoRetailDataProvider dataProvider) {
            _dataProvider = dataProvider;
        }

    }
}
