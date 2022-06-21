using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {

    public class ChartDrillDownDataProvider : IChartDrillDownDataProvider {
        public List<SaleItem> Generate() {
            return SaleItem.GetTotalIncome();
        }
    }

}
