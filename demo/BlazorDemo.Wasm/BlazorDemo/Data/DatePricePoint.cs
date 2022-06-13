using System;

namespace BlazorDemo.Data {
    public class DatePricePoint {
        public DateTime DateTimeStamp { get; }
        public double Price { get; }

        public DatePricePoint(DateTime dateTimeStamp, double price) {
            (DateTimeStamp, Price) = (dateTimeStamp, price);
        }
    }
}
