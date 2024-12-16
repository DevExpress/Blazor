using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class SankeyDataProvider : ISankeyDataProvider {
        public List<SankeyDataPoint> GenerateData() {
            return new List<SankeyDataPoint>() {
                new SankeyDataPoint("Server products", "Revenue", 23953000000),
                new SankeyDataPoint("Office products", "Revenue", 13477000000),
                new SankeyDataPoint("Gaming", "Revenue", 7111000000),
                new SankeyDataPoint("Windows", "Revenue", 5262000000),
                new SankeyDataPoint("LinkedIn", "Revenue", 4195000000),
                new SankeyDataPoint("Search and news advertising", "Revenue", 3220000000),
                new SankeyDataPoint("Enterprise services", "Revenue", 1917000000),
                new SankeyDataPoint("Dynamic products and cloud services", "Revenue", 1576000000),
                new SankeyDataPoint("Devices", "Revenue", 1298000000),
                new SankeyDataPoint("Revenue", "Gross margin", 42400000000),
                new SankeyDataPoint("Gross margin", "Operating income", 27000000000),
                new SankeyDataPoint("Gross margin", "Operating expenses", 15400000000),
                new SankeyDataPoint("Operating income", "Net income", 21900000000),
                new SankeyDataPoint("Operating income", "Tax", 4700000000),
                new SankeyDataPoint("Operating income", "Other", 580000000),
                new SankeyDataPoint("Operating expenses", "R&D", 7100000000),
                new SankeyDataPoint("Operating expenses", "S&M", 6200000000),
                new SankeyDataPoint("Operating expenses", "G&A", 2000000000),
                new SankeyDataPoint("Revenue", "Cost of revenue", 19600000000),
            };
        }
    }
}
