using System.Collections.Generic;
using System.Linq;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class SparklineDataProvider : ISparklineDataProvider {
        const int CheckoutThreshold = 2200;
        const int ProductThreshold = 20000;
        const int PriceThreshold = 8000;

        const string CheckoutColor = "#f31b48";
        const string ProductColor = "#34bc3f";
        const string PriceColor = "#7989ff";

        List<SparklineDataPoint> GenerateSparklineData(List<int> values) {
            return values.Select((val, i) => new SparklineDataPoint(i, val)).ToList();
        }

        public List<SparklineGridDataRow> GenerateData() {
            var checkout = GenerateSparklineData(new List<int>() { 2210, 2103, 2132, 2234, 2062, 1954, 2112, 1967, 2009, 2087, 2112, 2038 });
            var product = GenerateSparklineData(new List<int>() { 18322, 21093, 19701, 17695, 17549, 16436, 16382, 15687, 16085, 18250, 16083, 17104 });
            var pricing = GenerateSparklineData(new List<int>() { 7501, 8470, 8591, 8459, 8320, 7465, 7475, 7430, 7614, 8245, 7727, 7880 });

            return new List<SparklineGridDataRow>() {
                new SparklineGridDataRow("Checkout", checkout, CheckoutColor, CheckoutThreshold),
                new SparklineGridDataRow("Product", product, ProductColor, ProductThreshold),
                new SparklineGridDataRow("Pricing", pricing, PriceColor, PriceThreshold),
            };
        }
    }
}
