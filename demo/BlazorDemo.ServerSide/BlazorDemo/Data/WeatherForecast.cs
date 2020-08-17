using System;

namespace BlazorDemo.Data {
    public class WeatherForecast {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public bool Precipitation { get; set; }

        public string Forecast { get; set; }

        public double TemperatureF => Math.Round((TemperatureC * 1.8 + 32), 2);
        public string CloudCover { get; set; }
    }
    public class Item {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isComplete { get; set; }
    }
}
