using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Data {
    public class Vacancy {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
    }
    public class Location {
        public string City { get; set; }
        public string Region { get; set; }
    }
    public static class VacancyRepository {
        public static string[] Regions;
        public static Location[] Locations;
        public static string[] VacancyNames;
        static VacancyRepository() {
            Regions = new string[] {
                "North America",
                "Europe, Middle East, Africa",
                "Asia/Pacific",
            };
            Locations = new Location[] {
                new Location() { Region = Regions[0],  City = "Vancouver" },
                new Location() { Region = Regions[0],  City = "Los Angeles" },
                new Location() { Region = Regions[0],  City = "New York" },
                new Location() { Region = Regions[0],  City = "Chicago" },
                new Location() { Region = Regions[0],  City = "Toronto" },
                new Location() { Region = Regions[1],  City = "London" },
                new Location() { Region = Regions[1],  City = "Abu Dhabi" },
                new Location() { Region = Regions[1],  City = "Cape Town" },
                new Location() { Region = Regions[1],  City = "Berlin" },
                new Location() { Region = Regions[1],  City = "Paris" },
                new Location() { Region = Regions[2],  City = "Seoul" },
                new Location() { Region = Regions[2],  City = "Tokyo" },
                new Location() { Region = Regions[2],  City = "Delhi" },
                new Location() { Region = Regions[2],  City = "Sydney" },
                new Location() { Region = Regions[2],  City = "Shanghai" },
            };
            VacancyNames = new string[] {
                "Sales Manager",
                "Junior Software Developer",
                "Senior Software Developer",
                "UI/UX Designer",
                "Art Director",
                "QA Engineer",
                "DevOps Engineer",
                "Release Engineer",
                "Support Engineer",
                "System Administrator",
                "Software Developer",
                "Product Manager",
                "Support Manager",
                "Network Engineer",
                "Security Engineer",
                "Computer Systems Analyst",
                "Network Architect",
                "Database Administrator",
                "Software Architect",
                "Web Administrator",
                "Big Data Architect",
                "Cloud Consultant",
                "Full Stack Developer",
                "Systems Analyst",
                "Mobile Application Developer",
                "Data Scientist",
                "HR Manager",
                "Agile Coach",
                "Machine Learning Engineer",
                "Technical Writer",
                "Project Manager",
            };
        }
        static List<Vacancy> GenerateData(int dataLength) {
            var vacancies = new List<Vacancy>();
            var vacancyCount = VacancyNames.Count();
            var someBigNumber = 1000;
            for (int i = someBigNumber; i < dataLength + someBigNumber; i++) {
                var region = Regions[i % Regions.Count()];
                var locations = GetOfficeLocationsByRegion(region).ToArray();
                var location = locations[i % locations.Count()].City;
                var description = VacancyNames[i % vacancyCount];
                vacancies.Add(new Vacancy() {
                    Id = i.ToString(),
                    Region = region,
                    City = location,
                    Description = description,
                });
            }

            return vacancies;
        }

        public static Task<Vacancy[]> GetVacancies(int dataLength) {
            return Task.FromResult(GenerateData(dataLength).ToArray());
        }
        public static IEnumerable<Location> GetOfficeLocationsByRegion(string region) {
            return Locations.Where(m => m.Region == region).ToList();
        }
    }
}
