namespace BlazorDemo.Data {
    public class DiscretePoint {
        public string Arg { get; set; }
        public int Day { get; set; }
        public int Night { get; set; }


        public DiscretePoint(string arg, int day, int night) {
            Arg = arg;
            Day = day;
            Night = night;
        }
    }
}
