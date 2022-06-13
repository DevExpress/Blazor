using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class PopulationCorrelationDataProvider : IPopulationCorrelationDataProvider {
        public Task<IEnumerable<PopulationCorrelationDataPoint>> GetData() {
            return Task.FromResult((IEnumerable<PopulationCorrelationDataPoint>)new List<PopulationCorrelationDataPoint> {
                new (){
                    Country = "Sweden",
                    TotalPopulation = 9.5,
                    Older60Population = 2.4,
                    Region = "Europe"
                },
                new (){
                    Country = "Nigeria",
                    TotalPopulation = 168.8,
                    Older60Population = 8.8,
                    Region = "Africa"
                },
                new (){
                    Country = "Japan",
                    TotalPopulation = 127.2,
                    Older60Population = 40.1,
                    Region = "Asia"
                },
                new (){
                    Country = "Germany",
                    TotalPopulation = 82.8,
                    Older60Population = 21.9,
                    Region = "Europe"
                },
                new (){
                    Country = "Ethiopia",
                    TotalPopulation = 91.7,
                    Older60Population = 4.6
                },
                new (){
                    Country = "Vietnam",
                    TotalPopulation = 90.8,
                    Older60Population = 8.0,
                    Region = "Asia"
                },
                new (){
                    Country = "Netherlands",
                    TotalPopulation = 16.7,
                    Older60Population = 3.8,
                    Region = "Europe"
                },
                new (){
                    Country = "Egypt",
                    TotalPopulation = 80.7,
                    Older60Population = 7.0,
                    Region = "Africa"
                },
                new (){
                    Country = "Sri Lanka",
                    TotalPopulation = 21.1,
                    Older60Population = 2.7,
                    Region = "Asia"
                },
                new (){
                    Country = "United Kingdom",
                    TotalPopulation = 62.8,
                    Older60Population = 14.4,
                    Region = "Europe"
                },
                new (){
                    Country = "South Africa",
                    TotalPopulation = 52.4,
                    Older60Population = 4.0,
                    Region = "Africa"
                },
                new (){
                    Country = "Philippines",
                    TotalPopulation = 96.7,
                    Older60Population = 5.9,
                    Region = "Asia"
                },
                new (){
                    Country = "Poland",
                    TotalPopulation = 38.2,
                    Older60Population = 7.8,
                    Region = "Europe"
                },
                new (){
                    Country = "Kenya",
                    TotalPopulation = 43.2,
                    Older60Population = 1.8,
                    Region = "Africa"
                },
                new (){
                    Country = "Thailand",
                    TotalPopulation = 66.8,
                    Older60Population = 9.6,
                    Region = "Asia"
                },
                new (){
                    Country = "Ukraine",
                    TotalPopulation = 45.5,
                    Older60Population = 9.5,
                    Region = "Europe"
                },
                new (){
                    Country = "Bangladesh",
                    TotalPopulation = 154.7,
                    Older60Population = 10.3,
                    Region = "Asia"
                },
                new (){
                    Country = "Canada",
                    TotalPopulation = 34.8,
                    Older60Population = 7.2,
                    Region = "North America"
                },
                new (){
                    Country = "Mexico",
                    TotalPopulation = 120.8,
                    Older60Population = 11.0,
                    Region = "North America"
                }
            });
        }
    }
}
