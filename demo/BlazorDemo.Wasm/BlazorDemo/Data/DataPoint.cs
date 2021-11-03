using System;
using System.Runtime.InteropServices;

namespace BlazorDemo.Data {
    [Guid("AF9401FD-6D54-40F2-AB01-2BEFADF90AED")]
    public class DataPoint {
        public double X { get; }
        public double Y { get; }

        public DataPoint(double x, double y) {
            X = x;
            Y = y;
        }
    }
}
