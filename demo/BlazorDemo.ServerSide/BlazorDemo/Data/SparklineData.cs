using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data {
    public class SparklineDataPoint {
        public int Month { get; set; }
        public int VisitorCount { get; set; }

        public SparklineDataPoint(int month, int visitorCount) {
            Month = month;
            VisitorCount = visitorCount;
        }
    }

    public class SparklineGridDataRow {
        public string Page { get; set; }
        public IEnumerable<SparklineDataPoint> Data { get; }
        public string Color { get; set; }
        public int WinLossThreshold { get; set; }
        public int TotalVisits { get => Data.Sum(p => p.VisitorCount); }
        public int MonthlyAverage { get => Convert.ToInt32(Math.Floor(Data.Average(p => p.VisitorCount))); }


        public SparklineGridDataRow(string page, IEnumerable<SparklineDataPoint> data, string color, int winLossThreshold) {
            Page = page;
            Data = data;
            Color = color;
            WinLossThreshold = winLossThreshold;
        }
    }
}
