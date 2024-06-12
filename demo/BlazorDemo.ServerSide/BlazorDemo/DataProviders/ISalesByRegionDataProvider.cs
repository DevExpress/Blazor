using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ISalesByRegionDataProvider {
        public List<SalesByRegion> GenerateData();
    }
}
