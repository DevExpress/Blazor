using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders {
    public interface IChartApplePriceDataProvider {
        public List<ApplePrice> GenerateData();
    }
}
