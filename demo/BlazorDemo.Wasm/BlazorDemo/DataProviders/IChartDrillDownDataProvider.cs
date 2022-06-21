using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartDrillDownDataProvider {
        public List<SaleItem> Generate();
    }
}
