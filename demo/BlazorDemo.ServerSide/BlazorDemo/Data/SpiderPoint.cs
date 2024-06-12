namespace BlazorDemo.Data {
    public class SpiderPoint {
        public string Arg { get; set; }
        public double Apples { get; set; }
        public double Grapes { get; set; }
        public double Lemons { get; set; }
        public double Oranges { get; set; }

        public SpiderPoint(string arg, double apples, double grapes, double lemons, double oranges) {
            Arg = arg;
            Apples = apples;
            Grapes = grapes;
            Lemons = lemons;
            Oranges = oranges;
        }
    }
}
