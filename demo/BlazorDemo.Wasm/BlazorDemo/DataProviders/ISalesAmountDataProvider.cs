using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface ISalesAmountDataProvider {
        public List<SalesAmountData> GenerateData();
    }
}
