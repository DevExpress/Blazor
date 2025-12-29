using System;
using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace BlazorDemo.Services {
    public class CustomAIFunctions {
        public static AIFunction GetWeatherTool => AIFunctionFactory.Create(GetWeather);
        public static AIFunction GetTimeTool => AIFunctionFactory.Create(GetTimeWithZone);
        public static AIFunction TestExceptionTool => AIFunctionFactory.Create(TestException);

        [Description("Gets the current weather in the city")]
        public static string GetWeather([Description("The name of the city")] string city) {
            switch(city) {
                case "Los Angeles":
                    return GetTemperatureValue(20);
                case "London":
                    return GetTemperatureValue(15);
                default:
                    return $"The information about the weather in {city} is not available.";
            }
        }

        [Description("Gets the current time and time zone")]
        public static string GetTimeWithZone() {
            var now = DateTime.Now;
            var tz = TimeZoneInfo.Local;
            return $"{now:HH:mm} ({tz.DisplayName})";
        }

        [Description("A test function that always fails with an exception")]
        public static string TestException() {
            throw new InvalidOperationException("This function is designed to fail for demo purposes.");
        }

        static string GetTemperatureValue(int value) {
            var valueInFahrenheits = value * 9 / 5 + 32;
            return $"{valueInFahrenheits}\u00b0F ({value}\u00b0C)";
        }
    }
}
