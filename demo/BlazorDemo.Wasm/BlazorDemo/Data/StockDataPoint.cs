using System;

namespace BlazorDemo.Data {
    public class StockDataPoint {
        public DateTime DateTimeStamp { get; }
        public double Open { get; }
        public double High { get; }
        public double Low { get; }
        public double Close { get; }

        public StockDataPoint(DateTime dateTimeStamp, double open, double high, double low, double close) {
            DateTimeStamp = dateTimeStamp;
            (Open, High, Low, Close) = (open, high, low, close);
        }
    }
}
