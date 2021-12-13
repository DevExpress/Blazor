namespace BlazorDemo.Data {
    public class GlobalTemperatureIndexInfo {
        public int Year { get; }
        public double Value { get; }
        public double LowessValue { get; }

        public GlobalTemperatureIndexInfo(int argument, double value, double lowessValue) {
            Year = argument;
            Value = value;
            LowessValue = lowessValue;
        }
    }
}
