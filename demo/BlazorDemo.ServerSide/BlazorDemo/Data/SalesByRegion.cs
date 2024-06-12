namespace BlazorDemo.Data {
    public class SalesByRegion {
        public SalesByRegion(int id, int regionId, string region, decimal marchSales, decimal septemberSales, decimal marchSalesPrev, decimal septermberSalesPrev, double marketShare) {
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

        decimal Calc(decimal current, decimal previous) {
            return (current - previous) / current;
        }

        public decimal MarchChange {
            get => Calc(MarchSales, MarchSalesPrev);
        }

        public decimal SeptemberChange {
            get => Calc(SeptemberSales, SeptemberSalesPrev);
        }
    }
}
