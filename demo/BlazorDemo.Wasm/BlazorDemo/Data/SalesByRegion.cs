namespace BlazorDemo.Data {
    public class SalesByRegion {
        public SalesByRegion(int id, int regionId, string region, decimal[] monthlySales, decimal[] monthlySalesPrev, double marketShare) {
            ID = id;
            RegionID = regionId;
            Region = region;
            MonthlySales = monthlySales;
            MonthlySalesPrev = monthlySalesPrev;
            MarketShare = marketShare;
        }
        public int ID { get; set; }
        public int RegionID { get; set; }
        public string Region { get; set; }
        public decimal[] MonthlySales { get; set; }
        public decimal[] MonthlySalesPrev { get; set; }
        public double MarketShare { get; set; }

        decimal Calc(decimal current, decimal previous) {
            return (current - previous) / current;
        }

        public decimal JanuarySales => MonthlySales[0];
        public decimal FebruarySales => MonthlySales[1];
        public decimal MarchSales => MonthlySales[2];
        public decimal AprilSales => MonthlySales[3];
        public decimal MaySales => MonthlySales[4];
        public decimal JuneSales => MonthlySales[5];
        public decimal JulySales => MonthlySales[6];
        public decimal AugustSales => MonthlySales[7];
        public decimal SeptemberSales => MonthlySales[8];
        public decimal OctoberSales => MonthlySales[9];
        public decimal NovemberSales => MonthlySales[10];
        public decimal DecemberSales => MonthlySales[11];

        public decimal JanuaryChange => Calc(JanuarySales, MonthlySalesPrev[0]);
        public decimal FebruaryChange => Calc(FebruarySales, MonthlySalesPrev[1]);
        public decimal MarchChange => Calc(MarchSales, MonthlySalesPrev[2]);
        public decimal AprilChange => Calc(AprilSales, MonthlySalesPrev[3]);
        public decimal MayChange => Calc(MaySales, MonthlySalesPrev[4]);
        public decimal JuneChange => Calc(JuneSales, MonthlySalesPrev[5]);
        public decimal JulyChange => Calc(JulySales, MonthlySalesPrev[6]);
        public decimal AugustChange => Calc(AugustSales, MonthlySalesPrev[7]);
        public decimal SeptemberChange => Calc(SeptemberSales, MonthlySalesPrev[8]);
        public decimal OctoberChange => Calc(OctoberSales, MonthlySalesPrev[9]);
        public decimal NovemberChange => Calc(NovemberSales, MonthlySalesPrev[10]);
        public decimal DecemberChange => Calc(DecemberSales, MonthlySalesPrev[11]);
    }
}
