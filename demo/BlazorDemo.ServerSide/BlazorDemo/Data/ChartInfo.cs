namespace BlazorDemo.Data {
    public class ChartInfo {
        public string Type { get; set; }
        public string Title { get; set; }

        public ChartInfo (string type, string title) {
            Type = type;
            Title = title;
        }
    }
}
