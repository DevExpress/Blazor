using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class PopulationAgeStructureDataProvider : IPopulationStructureDataProvider {
        public Task<IEnumerable<PopulationAgeStructureItem>> QueryData() {
            List<PopulationAgeStructureItem> list = new() {
                new("0-14 years", "Male", "United States", 31374555),
                new("15-64 years", "Male", "United States", 107515774),
                new("65 years and older", "Male", "United States", 25014147),
                new("0-14 years", "Female", "United States", 30034371),
                new("15-64 years", "Female", "United States", 107662836),
                new("65 years and older", "Female", "United States", 31037419),

                new("0-14 years", "Male", "Brazil", 22790634),
                new("15-64 years", "Male", "Brazil", 73127598),
                new("65 years and older", "Male", "Brazil", 8323344),
                new("0-14 years", "Female", "Brazil", 21907018),
                new("15-64 years", "Female", "Brazil", 74391361),
                new("65 years and older", "Female", "Brazil", 11176018),

                new("0-14 years", "Male", "Russia", 12551611),
                new("15-64 years", "Male", "Russia", 45968660),
                new("65 years and older", "Male", "Russia", 7033381),
                new("0-14 years", "Female", "Russia", 11881297),
                new("15-64 years", "Female", "Russia", 49315577),
                new("65 years and older", "Female", "Russia", 14971679),

                new("0-14 years", "Male", "Japan", 8047183),
                new("15-64 years", "Male", "Japan", 36685804),
                new("65 years and older", "Male", "Japan", 16034973),
                new("0-14 years", "Female", "Japan", 7623767),
                new("15-64 years", "Female", "Japan", 36523249),
                new("65 years and older", "Female", "Japan", 20592496),

                new("0-14 years", "Male", "Mexico", 17111199),
                new("15-64 years", "Male", "Mexico", 41552531),
                new("65 years and older", "Male", "Mexico", 4373807),
                new("0-14 years", "Female", "Mexico", 16349767),
                new("15-64 years", "Female", "Mexico", 43770680),
                new("65 years and older", "Female", "Mexico", 5491581),

                new("0-14 years", "Male", "Germany", 5302850),
                new("15-64 years", "Male", "Germany", 25863626),
                new("65 years and older", "Male", "Germany", 8148873),
                new("0-14 years", "Female", "Germany", 5025863),
                new("15-64 years", "Female", "Germany", 25540912),
                new("65 years and older", "Female", "Germany", 10277538),

                new("0-14 years", "Male", "United Kingdom", 5943435),
                new("15-64 years", "Male", "United Kingdom", 21339778),
                new("65 years and older", "Male", "United Kingdom", 5470116),
                new("0-14 years", "Female", "United Kingdom", 5651780),
                new("15-64 years", "Female", "United Kingdom", 20674697),
                new("65 years and older", "Female", "United Kingdom", 6681311),
            };
            return Task.FromResult((IEnumerable<PopulationAgeStructureItem>)list);
        }
    }
}
