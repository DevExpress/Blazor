using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class ChartDiscreteDataProvider : IChartDiscreteDataProvider {
        public List<DiscretePoint> GenerateData() {
            return new List<DiscretePoint>() {
                new DiscretePoint("January", 6, 2),
                new DiscretePoint("February", 7, 2),
                new DiscretePoint("March", 10, 3),
                new DiscretePoint("April", 14, 5),
                new DiscretePoint("May", 18, 8),
                new DiscretePoint("June", 21, 11),
                new DiscretePoint("July", 22, 13),
                new DiscretePoint("August", 22, 13),
                new DiscretePoint("September", 19, 11),
                new DiscretePoint("October", 15, 8),
                new DiscretePoint("November", 10, 5),
                new DiscretePoint("December", 7, 3),
            };
        }
    }
}
