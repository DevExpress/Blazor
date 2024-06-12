namespace BlazorDemo.Data {
    public class WindRosePoint {
        public string Arg { get; set; }
        public double Val1 { get; set; }
        public double Val2 { get; set; }
        public double Val3 { get; set; }
        public double Val4 { get; set; }
        public double Val5 { get; set; }
        public double Val6 { get; set; }
        public double Val7 { get; set; }
        public double Val8 { get; set; }

        public WindRosePoint(string arg, double val1, double val2, double val3, double val4, double val5, double val6, double val7, double val8) {
            Arg = arg;
            Val1 = val1;
            Val2 = val2;
            Val3 = val3;
            Val4 = val4;
            Val5 = val5;
            Val6 = val6;
            Val7 = val7;
            Val8 = val8;
        }
    }
}
