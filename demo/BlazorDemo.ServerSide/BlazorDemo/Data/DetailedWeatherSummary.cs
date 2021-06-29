using System;

namespace BlazorDemo.Data {
    public class DetailedWeatherSummary {
        public DateTime Date { get; set; }
        public string City { get; set; }
        public double MaxTemperatureF { get; set; }
        public double MinTemperatureF { get; set; }
        public double AverageTemperatureF { get; set; }
        public double PrecipitationInch { get; set; }
    }
}
