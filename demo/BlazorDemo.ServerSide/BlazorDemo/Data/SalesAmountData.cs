namespace BlazorDemo.Data {
    public class SalesAmountData {

        public int Year { get; init; }

        public string ProductCategory { get; init; }

        public double SalesAmount { get; init; }

        public SalesAmountData(int year, string productCategory, double salesAmount) {
            Year = year;
            ProductCategory = productCategory;
            SalesAmount = salesAmount;
        }
    }
}
