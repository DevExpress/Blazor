using System;

namespace BlazorDemo.Data {
    public class TemperatureData {
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public TemperatureData(DateTime date, double temperature) {
            Date = date;
            Temperature = temperature;
        }
    }
}
