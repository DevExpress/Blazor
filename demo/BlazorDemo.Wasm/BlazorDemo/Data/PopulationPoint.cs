namespace BlazorDemo.Data {
    public class PopulationPoint {
        public string Country { get; set; }
        public long Value { get; set; }
        public PopulationPoint(string country, long value) {
            Country = country;
            Value = value;
        }
    }
}
