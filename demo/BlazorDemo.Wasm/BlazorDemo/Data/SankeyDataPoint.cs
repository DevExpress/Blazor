namespace BlazorDemo.Data {
    public class SankeyDataPoint {
        public SankeyDataPoint(string source, string target, long weight) {
            Source = source;
            Target = target;
            Weight = weight;
        }

        public string Source { get; set; }
        public string Target { get; set; }
        public long Weight { get; set; }
    }
}
