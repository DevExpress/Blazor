using System;
using System.Collections.Generic;

namespace Demo.RazorComponents.Model
{
    public static class CountryCity
    {
        private static readonly Lazy<List<Country>> countries = new Lazy<List<Country>>(() =>
        {
            return new List<Country>()
            {
                new Country() { Id = 0, CountryName = "USA" },
                new Country() { Id = 1, CountryName = "Germany" },
                new Country() { Id = 2, CountryName = "Japan" }
            };
        });
        private static readonly Lazy<List<City>> cities = new Lazy<List<City>>(() =>
        {
            return new List<City>() {
                new City() { Id = 0, CountryId = 0, CityName = "Washington" },
                new City() { Id = 1, CountryId = 0, CityName = "New York" },
                new City() { Id = 2, CountryId = 0, CityName = "Los Angeles" },
                new City() { Id = 3, CountryId = 1, CityName = "Berlin" },
                new City() { Id = 4, CountryId = 1, CityName = "Munich" },
                new City() { Id = 5, CountryId = 1, CityName = "Hamburg" },
                new City() { Id = 6, CountryId = 2, CityName = "Tokyo" },
                new City() { Id = 7, CountryId = 2, CityName = "Osaka" },
                new City() { Id = 8, CountryId = 2, CityName = "Yokohama" }
            };
        });
        public static List<Country> Countries { get { return countries.Value; } }
        public static List<City> Cities { get { return cities.Value; } }
    }
}

