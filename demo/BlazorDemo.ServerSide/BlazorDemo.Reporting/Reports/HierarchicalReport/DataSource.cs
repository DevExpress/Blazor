using System.Collections.Generic;
using System.ComponentModel;

namespace Demo.Blazor.Reports.HierarchicalReport {
    [DisplayName("Hierarchical Report Data Source")]
    public class DataSource {
        public static List<SalesData> GetData() {
            List<SalesData> sales = new List<SalesData>();
            sales.Add(new SalesData(0, -1, "Western Europe", 30540, 33000, 32220, 35500, .70));
            sales.Add(new SalesData(1, 0, "Austria", 22000, 28000, 26120, 28500, .92));
            sales.Add(new SalesData(2, 0, "Belgium", 13000, 9640, 14500, 11200, .16));
            sales.Add(new SalesData(3, 0, "Denmark", 21000, 18100, 17120, 15500, .56));
            sales.Add(new SalesData(4, 0, "Finland", 17000, 17420, 18120, 19200, .44));
            sales.Add(new SalesData(5, 0, "France", 23020, 27000, 20120, 24200, .51));
            sales.Add(new SalesData(6, 0, "Germany", 30540, 33000, 32220, 35500, .93));
            sales.Add(new SalesData(7, 0, "Greece", 15600, 13200, 11500, 11000, .11));
            sales.Add(new SalesData(8, 0, "Ireland", 9530, 10939, 12620, 12990, .34));
            sales.Add(new SalesData(9, 0, "Italy", 17299, 19321, 14120, 15945, .22));
            sales.Add(new SalesData(11, 0, "Netherlands", 8902, 9214, 7400, 9600, .85));
            sales.Add(new SalesData(12, 0, "Norway", 5400, 7310, 5200, 6880, .7));
            sales.Add(new SalesData(13, 0, "Portugal", 9220, 4271, 4100, 3880, .5));
            sales.Add(new SalesData(14, 0, "Spain", 12900, 10300, 14300, 14900, .82));
            sales.Add(new SalesData(15, 0, "Switzerland", 9323, 10730, 7244, 9400, .14));
            sales.Add(new SalesData(16, 0, "United Kingdom", 14580, 13967, 15200, 16900, .91));

            sales.Add(new SalesData(17, -1, "Eastern Europe", 22500, 24580, 21225, 22698, .62));
            sales.Add(new SalesData(18, 17, "Belarus", 7315, 18800, 8240, 17480, .34));
            sales.Add(new SalesData(19, 17, "Bulgaria", 6300, 2821, 5200, 4880, .8));
            sales.Add(new SalesData(20, 17, "Croatia", 4200, 3890, 3880, 4430, .29));
            sales.Add(new SalesData(21, 17, "Czech Republic", 19500, 15340, 16230, 14980, .13));
            sales.Add(new SalesData(22, 17, "Hungary", 13495, 13900, 10245, 9560, .14));
            sales.Add(new SalesData(23, 17, "Poland", 8930, 9440, 12200, 12150, .52));
            sales.Add(new SalesData(24, 17, "Romania", 4900, 5100, 5241, 6284, .30));
            sales.Add(new SalesData(25, 17, "Russia", 22500, 24580, 21225, 22698, .85));

            sales.Add(new SalesData(26, -1, "North America", 31400, 32800, 30300, 31940, .84));
            sales.Add(new SalesData(27, 26, "USA", 31400, 32800, 30300, 31940, .87));
            sales.Add(new SalesData(28, 26, "Canada", 25390, 27000, 5200, 6880, .64));

            sales.Add(new SalesData(29, -1, "South America", 16380, 17590, 15400, 16680, .32));
            sales.Add(new SalesData(30, 29, "Argentina", 16380, 17590, 15400, 16680, .88));
            sales.Add(new SalesData(31, 29, "Brazil", 4560, 9480, 3900, 6100, .10));

            sales.Add(new SalesData(32, -1, "Asia", 20388, 22547, 22500, 25756, .52));
            sales.Add(new SalesData(34, 32, "India", 4642, 5320, 4200, 6470, .44));
            sales.Add(new SalesData(35, 32, "Japan", 9457, 12859, 8300, 8733, .70));
            sales.Add(new SalesData(36, 32, "China", 20388, 22547, 22500, 25756, .82));
            return sales;
        }
    }
    public class SalesData {
        public SalesData(int id, int regionId, string region, decimal marchSales, decimal septemberSales, decimal marchSalesPrev, decimal septermberSalesPrev, double marketShare) {
            ID = id;
            RegionID = regionId;
            Region = region;
            MarchSales = marchSales;
            SeptemberSales = septemberSales;
            MarchSalesPrev = marchSalesPrev;
            SeptemberSalesPrev = septermberSalesPrev;
            MarketShare = marketShare;
        }
        public int ID { get; set; }
        public int RegionID { get; set; }
        public string Region { get; set; }
        public decimal MarchSales { get; set; }
        public decimal SeptemberSales { get; set; }
        public decimal MarchSalesPrev { get; set; }
        public decimal SeptemberSalesPrev { get; set; }
        public double MarketShare { get; set; }
    }
}
