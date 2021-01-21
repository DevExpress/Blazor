using System;

namespace BlazorDemo.Data {
    public class BargainDataPoint {
        public DateTime DateTimeStamp { get; }
        public double Price { get; }

        public BargainDataPoint(DateTime dateTimeStamp, double price) {
            DateTimeStamp = dateTimeStamp;
            Price = price;
        }
    }
}
