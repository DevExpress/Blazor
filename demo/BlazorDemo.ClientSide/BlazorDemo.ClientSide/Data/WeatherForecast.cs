using System;

namespace Demo.Blazor.Services
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public bool Precipitates { get; set; }

        public string Summary { get; set; }

        public double TemperatureF => Math.Round((TemperatureC * 1.8 + 32), 2);
        public string WeatherType { get; set; }
    }
    public class Item {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool isComplete { get; set; }
    }
}
