using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model
{
    public class Vacancy
    {
        public string Description { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }
    public class Location
    {
        public string City { get; set; }
        public string Region { get; set; }
    }
    public static class VacancyRepository
    {
        public static string[] Regions;
        public static Location[] Locations;
        public static IEnumerable<Vacancy> Vacancies;
        static VacancyRepository()
        {
            Regions = new string[] {
                "North America",
                "Europe, Middle East, Africa",
                "Asia/Pacific",
            };
            Locations = new Location[] {
                new Location() { Region = Regions[0],  City = "New York" },
                new Location() { Region = Regions[0],  City = "Los Angeles" },
                new Location() { Region = Regions[0],  City = "Vancouver" },
                new Location() { Region = Regions[1],  City = "London" },
                new Location() { Region = Regions[1],  City = "Abu Dhabi" },
                new Location() { Region = Regions[1],  City = "Cape Town" },
                new Location() { Region = Regions[2],  City = "Tokyo" },
                new Location() { Region = Regions[2],  City = "Seoul" },
                new Location() { Region = Regions[2],  City = "Sydney" }
            };
        }
        public static Task<Vacancy[]> GetVacancies()
        {
            return Task.FromResult(new Vacancy[]
            {
                    new Vacancy () { Description = "Sales", Region = Regions[0], City = GetOfficeLocationsByRegion(Regions[0]).First().City },
                    new Vacancy () { Description = "Engineer", Region = Regions[1], City = GetOfficeLocationsByRegion(Regions[1]).First().City },
                    new Vacancy () { Description = "Designer", Region = Regions[2], City = GetOfficeLocationsByRegion(Regions[2]).First().City },
            });
        }
        public static IEnumerable<Location> GetOfficeLocationsByRegion(string region)
        {
            return Locations.Where(m => m.Region == region).ToList();
        }
    }
}
