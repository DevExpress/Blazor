using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class PopulationDataProvider : IPopulationDataProvider {
        public List<PopulationPoint> GetData() {
            var result = new List<PopulationPoint>(14);
            result.Add(new PopulationPoint("India", 1428627663));
            result.Add(new PopulationPoint("China", 1425671352));
            result.Add(new PopulationPoint("United States", 339996563));
            result.Add(new PopulationPoint("Indonesia", 277534122));
            result.Add(new PopulationPoint("Pakistan", 240485658));
            result.Add(new PopulationPoint("Nigeria", 223804632));
            result.Add(new PopulationPoint("Brazil", 216422446));
            result.Add(new PopulationPoint("Bangladesh", 172954319));
            result.Add(new PopulationPoint("Russia", 144444359));
            result.Add(new PopulationPoint("Mexico", 128455567));
            result.Add(new PopulationPoint("Ethiopia", 126527060));
            result.Add(new PopulationPoint("Japan", 123294513));
            result.Add(new PopulationPoint("Philippines", 117337368));
            result.Add(new PopulationPoint("Egypt", 112716598));

            return result;
        }
    }
}
