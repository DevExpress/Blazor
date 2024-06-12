namespace BlazorDemo.Data {
    public class ApplePrice {
        public string Date { get; set; }
        public double Close { get; set; }
        public ApplePrice(string date, double close) {
            Date = date;
            Close = close;
        }
    }
}
