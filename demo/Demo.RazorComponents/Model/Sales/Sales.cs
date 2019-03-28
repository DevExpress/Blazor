using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.RazorComponents.Model;

namespace Demo.RazorComponents.Model
{

    public class Sales
    {
        static IList<SaleInfo> dataSource;
        static Sales()
        {
            CreateDataSource();
        }

        static void CreateDataSource()
        {
            dataSource = new List<SaleInfo> {
                new SaleInfo {
                    OrderId = 10248,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 1740,
                    Date = DateTime.Parse("2013/01/06")
                },
                new SaleInfo {
                    OrderId = 10249,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 850,
                    Date = DateTime.Parse("2013/01/13")
                },
                new SaleInfo {
                    OrderId = 10250,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2235,
                    Date = DateTime.Parse("2013/01/07")
                },
                new SaleInfo {
                    OrderId = 10251,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1965,
                    Date = DateTime.Parse("2013/01/03")
                },
                new SaleInfo {
                    OrderId = 10252,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 880,
                    Date = DateTime.Parse("2013/01/10")
                },
                new SaleInfo {
                    OrderId = 10253,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 5260,
                    Date = DateTime.Parse("2013/01/17")
                },
                new SaleInfo {
                    OrderId = 10254,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 2790,
                    Date = DateTime.Parse("2013/01/21")
                },
                new SaleInfo {
                    OrderId = 10255,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 3140,
                    Date = DateTime.Parse("2013/01/01")
                },
                new SaleInfo {
                    OrderId = 10256,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 6175,
                    Date = DateTime.Parse("2013/01/24")
                },
                new SaleInfo {
                    OrderId = 10257,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 4575,
                    Date = DateTime.Parse("2013/01/11")
                },
                new SaleInfo {
                    OrderId = 10258,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 3680,
                    Date = DateTime.Parse("2013/01/12")
                },
                new SaleInfo {
                    OrderId = 10259,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2260,
                    Date = DateTime.Parse("2013/01/01")
                },
                new SaleInfo {
                    OrderId = 10260,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 2910,
                    Date = DateTime.Parse("2013/01/26")
                },
                new SaleInfo {
                    OrderId = 10261,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 8400,
                    Date = DateTime.Parse("2013/01/05")
                },
                new SaleInfo {
                    OrderId = 10262,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 1325,
                    Date = DateTime.Parse("2013/01/14")
                },
                new SaleInfo {
                    OrderId = 10263,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 3920,
                    Date = DateTime.Parse("2013/01/05")
                },
                new SaleInfo {
                    OrderId = 10264,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2220,
                    Date = DateTime.Parse("2013/01/15")
                },
                new SaleInfo {
                    OrderId = 10265,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 940,
                    Date = DateTime.Parse("2013/01/01")
                },
                new SaleInfo {
                    OrderId = 10266,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1630,
                    Date = DateTime.Parse("2013/01/10")
                },
                new SaleInfo {
                    OrderId = 10267,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2910,
                    Date = DateTime.Parse("2013/01/23")
                },
                new SaleInfo {
                    OrderId = 10268,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 2600,
                    Date = DateTime.Parse("2013/01/14")
                },
                new SaleInfo {
                    OrderId = 10269,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 4340,
                    Date = DateTime.Parse("2013/01/26")
                },
                new SaleInfo {
                    OrderId = 10270,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 6650,
                    Date = DateTime.Parse("2013/01/24")
                },
                new SaleInfo {
                    OrderId = 10271,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 490,
                    Date = DateTime.Parse("2013/01/22")
                },
                new SaleInfo {
                    OrderId = 10272,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 3390,
                    Date = DateTime.Parse("2013/01/25")
                },
                new SaleInfo {
                    OrderId = 10273,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 5160,
                    Date = DateTime.Parse("2013/02/20")
                },
                new SaleInfo {
                    OrderId = 10274,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 5750,
                    Date = DateTime.Parse("2013/02/12")
                },
                new SaleInfo {
                    OrderId = 10275,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2805,
                    Date = DateTime.Parse("2013/02/13")
                },
                new SaleInfo {
                    OrderId = 10276,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2505,
                    Date = DateTime.Parse("2013/02/09")
                },
                new SaleInfo {
                    OrderId = 10277,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 930,
                    Date = DateTime.Parse("2013/02/04")
                },
                new SaleInfo {
                    OrderId = 10278,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 1240,
                    Date = DateTime.Parse("2013/02/03")
                },
                new SaleInfo {
                    OrderId = 10279,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 315,
                    Date = DateTime.Parse("2013/02/04")
                },
                new SaleInfo {
                    OrderId = 10280,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2870,
                    Date = DateTime.Parse("2013/02/18")
                },
                new SaleInfo {
                    OrderId = 10281,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 5150,
                    Date = DateTime.Parse("2013/02/18")
                },
                new SaleInfo {
                    OrderId = 10282,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 2725,
                    Date = DateTime.Parse("2013/02/20")
                },
                new SaleInfo {
                    OrderId = 10283,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2840,
                    Date = DateTime.Parse("2013/02/04")
                },
                new SaleInfo {
                    OrderId = 10284,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5840,
                    Date = DateTime.Parse("2013/02/13")
                },
                new SaleInfo {
                    OrderId = 10285,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 6750,
                    Date = DateTime.Parse("2013/02/11")
                },
                new SaleInfo {
                    OrderId = 10286,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1200,
                    Date = DateTime.Parse("2013/02/03")
                },
                new SaleInfo {
                    OrderId = 10287,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4550,
                    Date = DateTime.Parse("2013/02/08")
                },
                new SaleInfo {
                    OrderId = 10288,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 6040,
                    Date = DateTime.Parse("2013/02/17")
                },
                new SaleInfo {
                    OrderId = 10289,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2205,
                    Date = DateTime.Parse("2013/02/08")
                },
                new SaleInfo {
                    OrderId = 10290,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 990,
                    Date = DateTime.Parse("2013/02/20")
                },
                new SaleInfo {
                    OrderId = 10291,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 700,
                    Date = DateTime.Parse("2013/02/11")
                },
                new SaleInfo {
                    OrderId = 10292,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2325,
                    Date = DateTime.Parse("2013/02/15")
                },
                new SaleInfo {
                    OrderId = 10293,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 930,
                    Date = DateTime.Parse("2013/02/21")
                },
                new SaleInfo {
                    OrderId = 10294,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1560,
                    Date = DateTime.Parse("2013/02/04")
                },
                new SaleInfo {
                    OrderId = 10295,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 1740,
                    Date = DateTime.Parse("2013/03/04")
                },
                new SaleInfo {
                    OrderId = 10296,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 3575,
                    Date = DateTime.Parse("2013/03/20")
                },
                new SaleInfo {
                    OrderId = 10297,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 4500,
                    Date = DateTime.Parse("2013/03/04")
                },
                new SaleInfo {
                    OrderId = 10298,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1605,
                    Date = DateTime.Parse("2013/03/17")
                },
                new SaleInfo {
                    OrderId = 10299,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 800,
                    Date = DateTime.Parse("2013/03/21")
                },
                new SaleInfo {
                    OrderId = 10300,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 640,
                    Date = DateTime.Parse("2013/03/08")
                },
                new SaleInfo {
                    OrderId = 10301,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 735,
                    Date = DateTime.Parse("2013/03/19")
                },
                new SaleInfo {
                    OrderId = 10302,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2520,
                    Date = DateTime.Parse("2013/03/20")
                },
                new SaleInfo {
                    OrderId = 10303,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 6675,
                    Date = DateTime.Parse("2013/03/18")
                },
                new SaleInfo {
                    OrderId = 10304,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 3625,
                    Date = DateTime.Parse("2013/03/25")
                },
                new SaleInfo {
                    OrderId = 10305,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 1200,
                    Date = DateTime.Parse("2013/03/07")
                },
                new SaleInfo {
                    OrderId = 10306,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2000,
                    Date = DateTime.Parse("2013/03/07")
                },
                new SaleInfo {
                    OrderId = 10307,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 1410,
                    Date = DateTime.Parse("2013/03/10")
                },
                new SaleInfo {
                    OrderId = 10308,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 2700,
                    Date = DateTime.Parse("2013/03/19")
                },
                new SaleInfo {
                    OrderId = 10309,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 5950,
                    Date = DateTime.Parse("2013/03/24")
                },
                new SaleInfo {
                    OrderId = 10310,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 5120,
                    Date = DateTime.Parse("2013/03/08")
                },
                new SaleInfo {
                    OrderId = 10311,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1980,
                    Date = DateTime.Parse("2013/03/17")
                },
                new SaleInfo {
                    OrderId = 10312,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1110,
                    Date = DateTime.Parse("2013/03/08")
                },
                new SaleInfo {
                    OrderId = 10313,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 980,
                    Date = DateTime.Parse("2013/03/21")
                },
                new SaleInfo {
                    OrderId = 10314,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 5460,
                    Date = DateTime.Parse("2013/03/19")
                },
                new SaleInfo {
                    OrderId = 10315,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 3800,
                    Date = DateTime.Parse("2013/03/12")
                },
                new SaleInfo {
                    OrderId = 10316,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2610,
                    Date = DateTime.Parse("2013/03/04")
                },
                new SaleInfo {
                    OrderId = 10317,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 3080,
                    Date = DateTime.Parse("2013/03/22")
                },
                new SaleInfo {
                    OrderId = 10318,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 2010,
                    Date = DateTime.Parse("2013/03/23")
                },
                new SaleInfo {
                    OrderId = 10319,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 1200,
                    Date = DateTime.Parse("2013/03/04")
                },
                new SaleInfo {
                    OrderId = 10320,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 7680,
                    Date = DateTime.Parse("2013/04/15")
                },
                new SaleInfo {
                    OrderId = 10321,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 1325,
                    Date = DateTime.Parse("2013/04/07")
                },
                new SaleInfo {
                    OrderId = 10322,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2835,
                    Date = DateTime.Parse("2013/04/10")
                },
                new SaleInfo {
                    OrderId = 10323,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3660,
                    Date = DateTime.Parse("2013/04/10")
                },
                new SaleInfo {
                    OrderId = 10324,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 390,
                    Date = DateTime.Parse("2013/04/12")
                },
                new SaleInfo {
                    OrderId = 10325,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 4420,
                    Date = DateTime.Parse("2013/04/08")
                },
                new SaleInfo {
                    OrderId = 10326,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1755,
                    Date = DateTime.Parse("2013/04/13")
                },
                new SaleInfo {
                    OrderId = 10327,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2580,
                    Date = DateTime.Parse("2013/04/15")
                },
                new SaleInfo {
                    OrderId = 10328,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 850,
                    Date = DateTime.Parse("2013/04/01")
                },
                new SaleInfo {
                    OrderId = 10329,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 2825,
                    Date = DateTime.Parse("2013/04/10")
                },
                new SaleInfo {
                    OrderId = 10330,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 540,
                    Date = DateTime.Parse("2013/04/06")
                },
                new SaleInfo {
                    OrderId = 10331,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1520,
                    Date = DateTime.Parse("2013/04/08")
                },
                new SaleInfo {
                    OrderId = 10332,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8760,
                    Date = DateTime.Parse("2013/04/26")
                },
                new SaleInfo {
                    OrderId = 10333,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1110,
                    Date = DateTime.Parse("2013/04/16")
                },
                new SaleInfo {
                    OrderId = 10334,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 6850,
                    Date = DateTime.Parse("2013/04/19")
                },
                new SaleInfo {
                    OrderId = 10335,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 1940,
                    Date = DateTime.Parse("2013/04/23")
                },
                new SaleInfo {
                    OrderId = 10336,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1980,
                    Date = DateTime.Parse("2013/04/21")
                },
                new SaleInfo {
                    OrderId = 10337,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 3090,
                    Date = DateTime.Parse("2013/04/03")
                },
                new SaleInfo {
                    OrderId = 10338,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1640,
                    Date = DateTime.Parse("2013/04/24")
                },
                new SaleInfo {
                    OrderId = 10339,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3585,
                    Date = DateTime.Parse("2013/04/01")
                },
                new SaleInfo {
                    OrderId = 10340,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1770,
                    Date = DateTime.Parse("2013/04/01")
                },
                new SaleInfo {
                    OrderId = 10341,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4005,
                    Date = DateTime.Parse("2013/04/04")
                },
                new SaleInfo {
                    OrderId = 10342,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2870,
                    Date = DateTime.Parse("2013/04/02")
                },
                new SaleInfo {
                    OrderId = 10343,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 960,
                    Date = DateTime.Parse("2013/04/20")
                },
                new SaleInfo {
                    OrderId = 10344,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 8640,
                    Date = DateTime.Parse("2013/05/14")
                },
                new SaleInfo {
                    OrderId = 10345,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 5450,
                    Date = DateTime.Parse("2013/05/24")
                },
                new SaleInfo {
                    OrderId = 10346,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2535,
                    Date = DateTime.Parse("2013/05/07")
                },
                new SaleInfo {
                    OrderId = 10347,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1155,
                    Date = DateTime.Parse("2013/05/20")
                },
                new SaleInfo {
                    OrderId = 10348,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 3140,
                    Date = DateTime.Parse("2013/05/18")
                },
                new SaleInfo {
                    OrderId = 10349,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2260,
                    Date = DateTime.Parse("2013/05/19")
                },
                new SaleInfo {
                    OrderId = 10350,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1215,
                    Date = DateTime.Parse("2013/05/23")
                },
                new SaleInfo {
                    OrderId = 10351,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1210,
                    Date = DateTime.Parse("2013/05/08")
                },
                new SaleInfo {
                    OrderId = 10352,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 875,
                    Date = DateTime.Parse("2013/05/25")
                },
                new SaleInfo {
                    OrderId = 10353,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5400,
                    Date = DateTime.Parse("2013/05/03")
                },
                new SaleInfo {
                    OrderId = 10354,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5940,
                    Date = DateTime.Parse("2013/05/25")
                },
                new SaleInfo {
                    OrderId = 10355,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 4700,
                    Date = DateTime.Parse("2013/05/03")
                },
                new SaleInfo {
                    OrderId = 10356,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 5520,
                    Date = DateTime.Parse("2013/05/12")
                },
                new SaleInfo {
                    OrderId = 10357,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 9210,
                    Date = DateTime.Parse("2013/05/22")
                },
                new SaleInfo {
                    OrderId = 10358,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 7950,
                    Date = DateTime.Parse("2013/05/12")
                },
                new SaleInfo {
                    OrderId = 10359,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 3740,
                    Date = DateTime.Parse("2013/05/24")
                },
                new SaleInfo {
                    OrderId = 10360,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 990,
                    Date = DateTime.Parse("2013/05/02")
                },
                new SaleInfo {
                    OrderId = 10361,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 3190,
                    Date = DateTime.Parse("2013/05/03")
                },
                new SaleInfo {
                    OrderId = 10362,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2430,
                    Date = DateTime.Parse("2013/05/11")
                },
                new SaleInfo {
                    OrderId = 10363,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 7380,
                    Date = DateTime.Parse("2013/06/15")
                },
                new SaleInfo {
                    OrderId = 10364,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 4475,
                    Date = DateTime.Parse("2013/06/08")
                },
                new SaleInfo {
                    OrderId = 10365,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 1290,
                    Date = DateTime.Parse("2013/06/10")
                },
                new SaleInfo {
                    OrderId = 10366,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2250,
                    Date = DateTime.Parse("2013/06/10")
                },
                new SaleInfo {
                    OrderId = 10367,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 350,
                    Date = DateTime.Parse("2013/06/22")
                },
                new SaleInfo {
                    OrderId = 10368,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 5480,
                    Date = DateTime.Parse("2013/06/24")
                },
                new SaleInfo {
                    OrderId = 10369,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 2355,
                    Date = DateTime.Parse("2013/06/10")
                },
                new SaleInfo {
                    OrderId = 10370,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1960,
                    Date = DateTime.Parse("2013/06/23")
                },
                new SaleInfo {
                    OrderId = 10371,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 4125,
                    Date = DateTime.Parse("2013/06/06")
                },
                new SaleInfo {
                    OrderId = 10372,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 7925,
                    Date = DateTime.Parse("2013/06/12")
                },
                new SaleInfo {
                    OrderId = 10373,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 1120,
                    Date = DateTime.Parse("2013/06/22")
                },
                new SaleInfo {
                    OrderId = 10374,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5100,
                    Date = DateTime.Parse("2013/06/01")
                },
                new SaleInfo {
                    OrderId = 10375,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 1500,
                    Date = DateTime.Parse("2013/06/25")
                },
                new SaleInfo {
                    OrderId = 10376,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 5130,
                    Date = DateTime.Parse("2013/06/10")
                },
                new SaleInfo {
                    OrderId = 10377,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 2475,
                    Date = DateTime.Parse("2013/06/10")
                },
                new SaleInfo {
                    OrderId = 10378,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 2100,
                    Date = DateTime.Parse("2013/06/06")
                },
                new SaleInfo {
                    OrderId = 10379,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3570,
                    Date = DateTime.Parse("2013/06/10")
                },
                new SaleInfo {
                    OrderId = 10380,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 550,
                    Date = DateTime.Parse("2013/06/02")
                },
                new SaleInfo {
                    OrderId = 10381,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2850,
                    Date = DateTime.Parse("2013/06/26")
                },
                new SaleInfo {
                    OrderId = 10382,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 4280,
                    Date = DateTime.Parse("2013/06/19")
                },
                new SaleInfo {
                    OrderId = 10383,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 1460,
                    Date = DateTime.Parse("2013/06/17")
                },
                new SaleInfo {
                    OrderId = 10384,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 960,
                    Date = DateTime.Parse("2013/06/17")
                },
                new SaleInfo {
                    OrderId = 10385,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1520,
                    Date = DateTime.Parse("2013/06/03")
                },
                new SaleInfo {
                    OrderId = 10386,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 6750,
                    Date = DateTime.Parse("2013/06/21")
                },
                new SaleInfo {
                    OrderId = 10387,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 7260,
                    Date = DateTime.Parse("2013/07/14")
                },
                new SaleInfo {
                    OrderId = 10388,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 2450,
                    Date = DateTime.Parse("2013/07/11")
                },
                new SaleInfo {
                    OrderId = 10389,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3540,
                    Date = DateTime.Parse("2013/07/02")
                },
                new SaleInfo {
                    OrderId = 10390,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1950,
                    Date = DateTime.Parse("2013/07/03")
                },
                new SaleInfo {
                    OrderId = 10391,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 360,
                    Date = DateTime.Parse("2013/07/07")
                },
                new SaleInfo {
                    OrderId = 10392,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 4500,
                    Date = DateTime.Parse("2013/07/03")
                },
                new SaleInfo {
                    OrderId = 10393,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4575,
                    Date = DateTime.Parse("2013/07/21")
                },
                new SaleInfo {
                    OrderId = 10394,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2310,
                    Date = DateTime.Parse("2013/07/18")
                },
                new SaleInfo {
                    OrderId = 10395,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 7500,
                    Date = DateTime.Parse("2013/07/04")
                },
                new SaleInfo {
                    OrderId = 10396,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 3575,
                    Date = DateTime.Parse("2013/07/23")
                },
                new SaleInfo {
                    OrderId = 10397,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 760,
                    Date = DateTime.Parse("2013/07/01")
                },
                new SaleInfo {
                    OrderId = 10398,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2400,
                    Date = DateTime.Parse("2013/07/11")
                },
                new SaleInfo {
                    OrderId = 10399,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 3330,
                    Date = DateTime.Parse("2013/07/04")
                },
                new SaleInfo {
                    OrderId = 10400,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 3480,
                    Date = DateTime.Parse("2013/07/23")
                },
                new SaleInfo {
                    OrderId = 10401,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4875,
                    Date = DateTime.Parse("2013/07/11")
                },
                new SaleInfo {
                    OrderId = 10402,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4980,
                    Date = DateTime.Parse("2013/07/19")
                },
                new SaleInfo {
                    OrderId = 10403,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2580,
                    Date = DateTime.Parse("2013/07/04")
                },
                new SaleInfo {
                    OrderId = 10404,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2650,
                    Date = DateTime.Parse("2013/07/16")
                },
                new SaleInfo {
                    OrderId = 10405,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1190,
                    Date = DateTime.Parse("2013/07/02")
                },
                new SaleInfo {
                    OrderId = 10406,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 960,
                    Date = DateTime.Parse("2013/07/26")
                },
                new SaleInfo {
                    OrderId = 10407,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 3600,
                    Date = DateTime.Parse("2013/08/08")
                },
                new SaleInfo {
                    OrderId = 10408,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 2250,
                    Date = DateTime.Parse("2013/08/01")
                },
                new SaleInfo {
                    OrderId = 10409,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 1275,
                    Date = DateTime.Parse("2013/08/02")
                },
                new SaleInfo {
                    OrderId = 10410,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3885,
                    Date = DateTime.Parse("2013/08/14")
                },
                new SaleInfo {
                    OrderId = 10411,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1900,
                    Date = DateTime.Parse("2013/08/05")
                },
                new SaleInfo {
                    OrderId = 10412,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2300,
                    Date = DateTime.Parse("2013/08/09")
                },
                new SaleInfo {
                    OrderId = 10413,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 2895,
                    Date = DateTime.Parse("2013/08/15")
                },
                new SaleInfo {
                    OrderId = 10414,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 350,
                    Date = DateTime.Parse("2013/08/20")
                },
                new SaleInfo {
                    OrderId = 10415,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 4200,
                    Date = DateTime.Parse("2013/08/22")
                },
                new SaleInfo {
                    OrderId = 10416,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 7175,
                    Date = DateTime.Parse("2013/08/14")
                },
                new SaleInfo {
                    OrderId = 10417,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 4420,
                    Date = DateTime.Parse("2013/08/24")
                },
                new SaleInfo {
                    OrderId = 10418,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5200,
                    Date = DateTime.Parse("2013/08/21")
                },
                new SaleInfo {
                    OrderId = 10419,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 7920,
                    Date = DateTime.Parse("2013/08/17")
                },
                new SaleInfo {
                    OrderId = 10420,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 6990,
                    Date = DateTime.Parse("2013/08/22")
                },
                new SaleInfo {
                    OrderId = 10421,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 2125,
                    Date = DateTime.Parse("2013/08/05")
                },
                new SaleInfo {
                    OrderId = 10422,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 2220,
                    Date = DateTime.Parse("2013/08/16")
                },
                new SaleInfo {
                    OrderId = 10423,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1575,
                    Date = DateTime.Parse("2013/08/23")
                },
                new SaleInfo {
                    OrderId = 10424,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1880,
                    Date = DateTime.Parse("2013/08/12")
                },
                new SaleInfo {
                    OrderId = 10425,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 710,
                    Date = DateTime.Parse("2013/08/25")
                },
                new SaleInfo {
                    OrderId = 10426,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 390,
                    Date = DateTime.Parse("2013/08/20")
                },
                new SaleInfo {
                    OrderId = 10427,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4635,
                    Date = DateTime.Parse("2013/08/04")
                },
                new SaleInfo {
                    OrderId = 10428,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 4350,
                    Date = DateTime.Parse("2013/08/19")
                },
                new SaleInfo {
                    OrderId = 10429,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 6020,
                    Date = DateTime.Parse("2013/08/02")
                },
                new SaleInfo {
                    OrderId = 10430,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 3660,
                    Date = DateTime.Parse("2013/08/19")
                },
                new SaleInfo {
                    OrderId = 10431,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 4525,
                    Date = DateTime.Parse("2013/08/24")
                },
                new SaleInfo {
                    OrderId = 10432,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 4410,
                    Date = DateTime.Parse("2013/09/12")
                },
                new SaleInfo {
                    OrderId = 10433,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 1725,
                    Date = DateTime.Parse("2013/09/07")
                },
                new SaleInfo {
                    OrderId = 10434,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2715,
                    Date = DateTime.Parse("2013/09/14")
                },
                new SaleInfo {
                    OrderId = 10435,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2820,
                    Date = DateTime.Parse("2013/09/08")
                },
                new SaleInfo {
                    OrderId = 10436,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2310,
                    Date = DateTime.Parse("2013/09/12")
                },
                new SaleInfo {
                    OrderId = 10437,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 780,
                    Date = DateTime.Parse("2013/09/08")
                },
                new SaleInfo {
                    OrderId = 10438,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 2370,
                    Date = DateTime.Parse("2013/09/19")
                },
                new SaleInfo {
                    OrderId = 10439,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1410,
                    Date = DateTime.Parse("2013/09/09")
                },
                new SaleInfo {
                    OrderId = 10440,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 1825,
                    Date = DateTime.Parse("2013/09/23")
                },
                new SaleInfo {
                    OrderId = 10441,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 4075,
                    Date = DateTime.Parse("2013/09/06")
                },
                new SaleInfo {
                    OrderId = 10442,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 1020,
                    Date = DateTime.Parse("2013/09/04")
                },
                new SaleInfo {
                    OrderId = 10443,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 4320,
                    Date = DateTime.Parse("2013/09/25")
                },
                new SaleInfo {
                    OrderId = 10444,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 7530,
                    Date = DateTime.Parse("2013/09/13")
                },
                new SaleInfo {
                    OrderId = 10445,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 2820,
                    Date = DateTime.Parse("2013/09/08")
                },
                new SaleInfo {
                    OrderId = 10446,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3050,
                    Date = DateTime.Parse("2013/09/04")
                },
                new SaleInfo {
                    OrderId = 10447,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 5080,
                    Date = DateTime.Parse("2013/09/25")
                },
                new SaleInfo {
                    OrderId = 10448,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1125,
                    Date = DateTime.Parse("2013/09/13")
                },
                new SaleInfo {
                    OrderId = 10449,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 850,
                    Date = DateTime.Parse("2013/09/24")
                },
                new SaleInfo {
                    OrderId = 10450,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1440,
                    Date = DateTime.Parse("2013/09/19")
                },
                new SaleInfo {
                    OrderId = 10451,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1950,
                    Date = DateTime.Parse("2013/09/02")
                },
                new SaleInfo {
                    OrderId = 10452,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 6390,
                    Date = DateTime.Parse("2013/10/11")
                },
                new SaleInfo {
                    OrderId = 10453,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 4625,
                    Date = DateTime.Parse("2013/10/02")
                },
                new SaleInfo {
                    OrderId = 10454,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3510,
                    Date = DateTime.Parse("2013/10/24")
                },
                new SaleInfo {
                    OrderId = 10455,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2730,
                    Date = DateTime.Parse("2013/10/15")
                },
                new SaleInfo {
                    OrderId = 10456,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2070,
                    Date = DateTime.Parse("2013/10/15")
                },
                new SaleInfo {
                    OrderId = 10457,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2320,
                    Date = DateTime.Parse("2013/10/18")
                },
                new SaleInfo {
                    OrderId = 10458,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4260,
                    Date = DateTime.Parse("2013/10/24")
                },
                new SaleInfo {
                    OrderId = 10459,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 840,
                    Date = DateTime.Parse("2013/10/18")
                },
                new SaleInfo {
                    OrderId = 10460,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 7300,
                    Date = DateTime.Parse("2013/10/24")
                },
                new SaleInfo {
                    OrderId = 10461,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5950,
                    Date = DateTime.Parse("2013/10/11")
                },
                new SaleInfo {
                    OrderId = 10462,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 3220,
                    Date = DateTime.Parse("2013/10/25")
                },
                new SaleInfo {
                    OrderId = 10463,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 3480,
                    Date = DateTime.Parse("2013/10/08")
                },
                new SaleInfo {
                    OrderId = 10464,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 4830,
                    Date = DateTime.Parse("2013/10/26")
                },
                new SaleInfo {
                    OrderId = 10465,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 4470,
                    Date = DateTime.Parse("2013/10/05")
                },
                new SaleInfo {
                    OrderId = 10466,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3675,
                    Date = DateTime.Parse("2013/10/23")
                },
                new SaleInfo {
                    OrderId = 10467,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4260,
                    Date = DateTime.Parse("2013/10/01")
                },
                new SaleInfo {
                    OrderId = 10468,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4245,
                    Date = DateTime.Parse("2013/10/26")
                },
                new SaleInfo {
                    OrderId = 10469,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1470,
                    Date = DateTime.Parse("2013/10/01")
                },
                new SaleInfo {
                    OrderId = 10470,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1810,
                    Date = DateTime.Parse("2013/10/02")
                },
                new SaleInfo {
                    OrderId = 10471,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 600,
                    Date = DateTime.Parse("2013/10/23")
                },
                new SaleInfo {
                    OrderId = 10472,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 7500,
                    Date = DateTime.Parse("2013/11/03")
                },
                new SaleInfo {
                    OrderId = 10473,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 4625,
                    Date = DateTime.Parse("2013/11/02")
                },
                new SaleInfo {
                    OrderId = 10474,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2625,
                    Date = DateTime.Parse("2013/11/09")
                },
                new SaleInfo {
                    OrderId = 10475,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1440,
                    Date = DateTime.Parse("2013/11/15")
                },
                new SaleInfo {
                    OrderId = 10476,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2420,
                    Date = DateTime.Parse("2013/11/15")
                },
                new SaleInfo {
                    OrderId = 10477,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 4180,
                    Date = DateTime.Parse("2013/11/15")
                },
                new SaleInfo {
                    OrderId = 10478,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 3720,
                    Date = DateTime.Parse("2013/11/25")
                },
                new SaleInfo {
                    OrderId = 10479,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2730,
                    Date = DateTime.Parse("2013/11/08")
                },
                new SaleInfo {
                    OrderId = 10480,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 3775,
                    Date = DateTime.Parse("2013/11/17")
                },
                new SaleInfo {
                    OrderId = 10481,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 3525,
                    Date = DateTime.Parse("2013/11/15")
                },
                new SaleInfo {
                    OrderId = 10482,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5320,
                    Date = DateTime.Parse("2013/11/08")
                },
                new SaleInfo {
                    OrderId = 10483,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5340,
                    Date = DateTime.Parse("2013/11/13")
                },
                new SaleInfo {
                    OrderId = 10484,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8850,
                    Date = DateTime.Parse("2013/11/01")
                },
                new SaleInfo {
                    OrderId = 10485,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 7050,
                    Date = DateTime.Parse("2013/11/14")
                },
                new SaleInfo {
                    OrderId = 10486,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4200,
                    Date = DateTime.Parse("2013/11/18")
                },
                new SaleInfo {
                    OrderId = 10487,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4960,
                    Date = DateTime.Parse("2013/11/04")
                },
                new SaleInfo {
                    OrderId = 10488,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2280,
                    Date = DateTime.Parse("2013/11/13")
                },
                new SaleInfo {
                    OrderId = 10489,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 590,
                    Date = DateTime.Parse("2013/11/11")
                },
                new SaleInfo {
                    OrderId = 10490,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 810,
                    Date = DateTime.Parse("2013/11/12")
                },
                new SaleInfo {
                    OrderId = 10491,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 2625,
                    Date = DateTime.Parse("2013/11/07")
                },
                new SaleInfo {
                    OrderId = 10492,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 8280,
                    Date = DateTime.Parse("2013/12/01")
                },
                new SaleInfo {
                    OrderId = 10493,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 5650,
                    Date = DateTime.Parse("2013/12/19")
                },
                new SaleInfo {
                    OrderId = 10494,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2760,
                    Date = DateTime.Parse("2013/12/14")
                },
                new SaleInfo {
                    OrderId = 10495,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2670,
                    Date = DateTime.Parse("2013/12/03")
                },
                new SaleInfo {
                    OrderId = 10496,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2520,
                    Date = DateTime.Parse("2013/12/20")
                },
                new SaleInfo {
                    OrderId = 10497,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 4080,
                    Date = DateTime.Parse("2013/12/21")
                },
                new SaleInfo {
                    OrderId = 10498,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4140,
                    Date = DateTime.Parse("2013/12/22")
                },
                new SaleInfo {
                    OrderId = 10499,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 390,
                    Date = DateTime.Parse("2013/12/04")
                },
                new SaleInfo {
                    OrderId = 10500,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 1400,
                    Date = DateTime.Parse("2013/12/19")
                },
                new SaleInfo {
                    OrderId = 10501,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 7275,
                    Date = DateTime.Parse("2013/12/22")
                },
                new SaleInfo {
                    OrderId = 10502,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 4100,
                    Date = DateTime.Parse("2013/12/20")
                },
                new SaleInfo {
                    OrderId = 10503,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5520,
                    Date = DateTime.Parse("2013/12/25")
                },
                new SaleInfo {
                    OrderId = 10504,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 9210,
                    Date = DateTime.Parse("2013/12/24")
                },
                new SaleInfo {
                    OrderId = 10505,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 7290,
                    Date = DateTime.Parse("2013/12/05")
                },
                new SaleInfo {
                    OrderId = 10506,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 625,
                    Date = DateTime.Parse("2013/12/22")
                },
                new SaleInfo {
                    OrderId = 10507,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4460,
                    Date = DateTime.Parse("2013/12/12")
                },
                new SaleInfo {
                    OrderId = 10508,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3825,
                    Date = DateTime.Parse("2013/12/13")
                },
                new SaleInfo {
                    OrderId = 10509,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2850,
                    Date = DateTime.Parse("2013/12/17")
                },
                new SaleInfo {
                    OrderId = 10510,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2780,
                    Date = DateTime.Parse("2013/12/07")
                },
                new SaleInfo {
                    OrderId = 10511,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 840,
                    Date = DateTime.Parse("2013/12/18")
                },
                new SaleInfo {
                    OrderId = 10512,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2970,
                    Date = DateTime.Parse("2013/12/23")
                },
                new SaleInfo {
                    OrderId = 10513,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 945,
                    Date = DateTime.Parse("2013/12/06")
                },
                new SaleInfo {
                    OrderId = 10514,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2625,
                    Date = DateTime.Parse("2013/12/04")
                },
                new SaleInfo {
                    OrderId = 10515,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 390,
                    Date = DateTime.Parse("2013/12/01")
                },
                new SaleInfo {
                    OrderId = 10516,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 2250,
                    Date = DateTime.Parse("2013/12/02")
                },
                new SaleInfo {
                    OrderId = 10517,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 7710,
                    Date = DateTime.Parse("2014/01/18")
                },
                new SaleInfo {
                    OrderId = 10518,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 7975,
                    Date = DateTime.Parse("2014/01/10")
                },
                new SaleInfo {
                    OrderId = 10519,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3285,
                    Date = DateTime.Parse("2014/01/13")
                },
                new SaleInfo {
                    OrderId = 10520,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2580,
                    Date = DateTime.Parse("2014/01/22")
                },
                new SaleInfo {
                    OrderId = 10521,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2160,
                    Date = DateTime.Parse("2014/01/26")
                },
                new SaleInfo {
                    OrderId = 10522,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 1100,
                    Date = DateTime.Parse("2014/01/25")
                },
                new SaleInfo {
                    OrderId = 10523,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4425,
                    Date = DateTime.Parse("2014/01/21")
                },
                new SaleInfo {
                    OrderId = 10524,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1360,
                    Date = DateTime.Parse("2014/01/22")
                },
                new SaleInfo {
                    OrderId = 10525,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 3250,
                    Date = DateTime.Parse("2014/01/14")
                },
                new SaleInfo {
                    OrderId = 10526,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5550,
                    Date = DateTime.Parse("2014/01/21")
                },
                new SaleInfo {
                    OrderId = 10527,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2860,
                    Date = DateTime.Parse("2014/01/25")
                },
                new SaleInfo {
                    OrderId = 10528,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5320,
                    Date = DateTime.Parse("2014/01/08")
                },
                new SaleInfo {
                    OrderId = 10529,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 4050,
                    Date = DateTime.Parse("2014/01/14")
                },
                new SaleInfo {
                    OrderId = 10530,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 3450,
                    Date = DateTime.Parse("2014/01/24")
                },
                new SaleInfo {
                    OrderId = 10531,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 5425,
                    Date = DateTime.Parse("2014/01/11")
                },
                new SaleInfo {
                    OrderId = 10532,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4860,
                    Date = DateTime.Parse("2014/01/12")
                },
                new SaleInfo {
                    OrderId = 10533,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4695,
                    Date = DateTime.Parse("2014/01/16")
                },
                new SaleInfo {
                    OrderId = 10534,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 610,
                    Date = DateTime.Parse("2014/01/05")
                },
                new SaleInfo {
                    OrderId = 10535,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1580,
                    Date = DateTime.Parse("2014/01/15")
                },
                new SaleInfo {
                    OrderId = 10536,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 3780,
                    Date = DateTime.Parse("2014/02/18")
                },
                new SaleInfo {
                    OrderId = 10537,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 5400,
                    Date = DateTime.Parse("2014/02/21")
                },
                new SaleInfo {
                    OrderId = 10538,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 630,
                    Date = DateTime.Parse("2014/02/18")
                },
                new SaleInfo {
                    OrderId = 10539,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3960,
                    Date = DateTime.Parse("2014/02/04")
                },
                new SaleInfo {
                    OrderId = 10540,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2010,
                    Date = DateTime.Parse("2014/02/25")
                },
                new SaleInfo {
                    OrderId = 10541,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 5000,
                    Date = DateTime.Parse("2014/02/01")
                },
                new SaleInfo {
                    OrderId = 10542,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1995,
                    Date = DateTime.Parse("2014/02/20")
                },
                new SaleInfo {
                    OrderId = 10543,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 860,
                    Date = DateTime.Parse("2014/02/12")
                },
                new SaleInfo {
                    OrderId = 10544,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 2150,
                    Date = DateTime.Parse("2014/02/10")
                },
                new SaleInfo {
                    OrderId = 10545,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 4050,
                    Date = DateTime.Parse("2014/02/06")
                },
                new SaleInfo {
                    OrderId = 10546,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2960,
                    Date = DateTime.Parse("2014/02/18")
                },
                new SaleInfo {
                    OrderId = 10547,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1780,
                    Date = DateTime.Parse("2014/02/26")
                },
                new SaleInfo {
                    OrderId = 10548,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8700,
                    Date = DateTime.Parse("2014/02/03")
                },
                new SaleInfo {
                    OrderId = 10549,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 3390,
                    Date = DateTime.Parse("2014/02/03")
                },
                new SaleInfo {
                    OrderId = 10550,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4425,
                    Date = DateTime.Parse("2014/02/15")
                },
                new SaleInfo {
                    OrderId = 10551,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 1180,
                    Date = DateTime.Parse("2014/02/23")
                },
                new SaleInfo {
                    OrderId = 10552,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 360,
                    Date = DateTime.Parse("2014/02/08")
                },
                new SaleInfo {
                    OrderId = 10553,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2310,
                    Date = DateTime.Parse("2014/02/13")
                },
                new SaleInfo {
                    OrderId = 10554,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1770,
                    Date = DateTime.Parse("2014/02/20")
                },
                new SaleInfo {
                    OrderId = 10555,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 3060,
                    Date = DateTime.Parse("2014/02/26")
                },
                new SaleInfo {
                    OrderId = 10556,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1750,
                    Date = DateTime.Parse("2014/02/12")
                },
                new SaleInfo {
                    OrderId = 10557,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 2280,
                    Date = DateTime.Parse("2014/03/09")
                },
                new SaleInfo {
                    OrderId = 10558,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 7600,
                    Date = DateTime.Parse("2014/03/25")
                },
                new SaleInfo {
                    OrderId = 10559,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 1035,
                    Date = DateTime.Parse("2014/03/23")
                },
                new SaleInfo {
                    OrderId = 10560,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1245,
                    Date = DateTime.Parse("2014/03/01")
                },
                new SaleInfo {
                    OrderId = 10561,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2860,
                    Date = DateTime.Parse("2014/03/19")
                },
                new SaleInfo {
                    OrderId = 10562,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 440,
                    Date = DateTime.Parse("2014/03/19")
                },
                new SaleInfo {
                    OrderId = 10563,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4665,
                    Date = DateTime.Parse("2014/03/02")
                },
                new SaleInfo {
                    OrderId = 10564,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2270,
                    Date = DateTime.Parse("2014/03/15")
                },
                new SaleInfo {
                    OrderId = 10565,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 5000,
                    Date = DateTime.Parse("2014/03/09")
                },
                new SaleInfo {
                    OrderId = 10566,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5100,
                    Date = DateTime.Parse("2014/03/23")
                },
                new SaleInfo {
                    OrderId = 10567,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2120,
                    Date = DateTime.Parse("2014/03/11")
                },
                new SaleInfo {
                    OrderId = 10568,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5140,
                    Date = DateTime.Parse("2014/03/05")
                },
                new SaleInfo {
                    OrderId = 10569,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 6210,
                    Date = DateTime.Parse("2014/03/19")
                },
                new SaleInfo {
                    OrderId = 10570,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 9510,
                    Date = DateTime.Parse("2014/03/19")
                },
                new SaleInfo {
                    OrderId = 10571,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 7600,
                    Date = DateTime.Parse("2014/03/21")
                },
                new SaleInfo {
                    OrderId = 10572,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 5420,
                    Date = DateTime.Parse("2014/03/15")
                },
                new SaleInfo {
                    OrderId = 10573,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1980,
                    Date = DateTime.Parse("2014/03/05")
                },
                new SaleInfo {
                    OrderId = 10574,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1820,
                    Date = DateTime.Parse("2014/03/07")
                },
                new SaleInfo {
                    OrderId = 10575,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1670,
                    Date = DateTime.Parse("2014/03/21")
                },
                new SaleInfo {
                    OrderId = 10576,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 4800,
                    Date = DateTime.Parse("2014/03/08")
                },
                new SaleInfo {
                    OrderId = 10577,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2925,
                    Date = DateTime.Parse("2014/03/03")
                },
                new SaleInfo {
                    OrderId = 10578,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 2940,
                    Date = DateTime.Parse("2014/04/11")
                },
                new SaleInfo {
                    OrderId = 10579,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 3525,
                    Date = DateTime.Parse("2014/04/13")
                },
                new SaleInfo {
                    OrderId = 10580,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2475,
                    Date = DateTime.Parse("2014/04/22")
                },
                new SaleInfo {
                    OrderId = 10581,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3315,
                    Date = DateTime.Parse("2014/04/08")
                },
                new SaleInfo {
                    OrderId = 10582,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 3140,
                    Date = DateTime.Parse("2014/04/07")
                },
                new SaleInfo {
                    OrderId = 10583,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2520,
                    Date = DateTime.Parse("2014/04/01")
                },
                new SaleInfo {
                    OrderId = 10584,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1200,
                    Date = DateTime.Parse("2014/04/10")
                },
                new SaleInfo {
                    OrderId = 10585,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2060,
                    Date = DateTime.Parse("2014/04/21")
                },
                new SaleInfo {
                    OrderId = 10586,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 7875,
                    Date = DateTime.Parse("2014/04/02")
                },
                new SaleInfo {
                    OrderId = 10587,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 1450,
                    Date = DateTime.Parse("2014/04/07")
                },
                new SaleInfo {
                    OrderId = 10588,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2640,
                    Date = DateTime.Parse("2014/04/22")
                },
                new SaleInfo {
                    OrderId = 10589,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1960,
                    Date = DateTime.Parse("2014/04/16")
                },
                new SaleInfo {
                    OrderId = 10590,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 2250,
                    Date = DateTime.Parse("2014/04/23")
                },
                new SaleInfo {
                    OrderId = 10591,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 4500,
                    Date = DateTime.Parse("2014/04/05")
                },
                new SaleInfo {
                    OrderId = 10592,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 5050,
                    Date = DateTime.Parse("2014/04/11")
                },
                new SaleInfo {
                    OrderId = 10593,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 2940,
                    Date = DateTime.Parse("2014/04/02")
                },
                new SaleInfo {
                    OrderId = 10594,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2880,
                    Date = DateTime.Parse("2014/04/14")
                },
                new SaleInfo {
                    OrderId = 10595,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1050,
                    Date = DateTime.Parse("2014/04/19")
                },
                new SaleInfo {
                    OrderId = 10596,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1850,
                    Date = DateTime.Parse("2014/04/02")
                },
                new SaleInfo {
                    OrderId = 10597,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 3160,
                    Date = DateTime.Parse("2014/04/01")
                },
                new SaleInfo {
                    OrderId = 10598,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 875,
                    Date = DateTime.Parse("2014/04/04")
                },
                new SaleInfo {
                    OrderId = 10599,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 3200,
                    Date = DateTime.Parse("2014/04/08")
                },
                new SaleInfo {
                    OrderId = 10600,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1380,
                    Date = DateTime.Parse("2014/04/21")
                },
                new SaleInfo {
                    OrderId = 10601,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 3060,
                    Date = DateTime.Parse("2014/04/06")
                },
                new SaleInfo {
                    OrderId = 10602,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 6690,
                    Date = DateTime.Parse("2014/05/19")
                },
                new SaleInfo {
                    OrderId = 10603,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 4525,
                    Date = DateTime.Parse("2014/05/15")
                },
                new SaleInfo {
                    OrderId = 10604,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 4665,
                    Date = DateTime.Parse("2014/05/10")
                },
                new SaleInfo {
                    OrderId = 10605,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 4530,
                    Date = DateTime.Parse("2014/05/18")
                },
                new SaleInfo {
                    OrderId = 10606,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1330,
                    Date = DateTime.Parse("2014/05/08")
                },
                new SaleInfo {
                    OrderId = 10607,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 1720,
                    Date = DateTime.Parse("2014/05/20")
                },
                new SaleInfo {
                    OrderId = 10608,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 3750,
                    Date = DateTime.Parse("2014/05/16")
                },
                new SaleInfo {
                    OrderId = 10609,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1290,
                    Date = DateTime.Parse("2014/05/10")
                },
                new SaleInfo {
                    OrderId = 10610,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 4925,
                    Date = DateTime.Parse("2014/05/14")
                },
                new SaleInfo {
                    OrderId = 10611,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 4300,
                    Date = DateTime.Parse("2014/05/22")
                },
                new SaleInfo {
                    OrderId = 10612,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5740,
                    Date = DateTime.Parse("2014/05/08")
                },
                new SaleInfo {
                    OrderId = 10613,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 3760,
                    Date = DateTime.Parse("2014/05/18")
                },
                new SaleInfo {
                    OrderId = 10614,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 7920,
                    Date = DateTime.Parse("2014/05/22")
                },
                new SaleInfo {
                    OrderId = 10615,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1440,
                    Date = DateTime.Parse("2014/05/21")
                },
                new SaleInfo {
                    OrderId = 10616,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 5975,
                    Date = DateTime.Parse("2014/05/25")
                },
                new SaleInfo {
                    OrderId = 10617,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4440,
                    Date = DateTime.Parse("2014/05/05")
                },
                new SaleInfo {
                    OrderId = 10618,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2310,
                    Date = DateTime.Parse("2014/05/24")
                },
                new SaleInfo {
                    OrderId = 10619,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2250,
                    Date = DateTime.Parse("2014/05/06")
                },
                new SaleInfo {
                    OrderId = 10620,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2320,
                    Date = DateTime.Parse("2014/05/14")
                },
                new SaleInfo {
                    OrderId = 10621,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8370,
                    Date = DateTime.Parse("2014/05/06")
                },
                new SaleInfo {
                    OrderId = 10622,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 5190,
                    Date = DateTime.Parse("2014/06/26")
                },
                new SaleInfo {
                    OrderId = 10623,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 925,
                    Date = DateTime.Parse("2014/06/04")
                },
                new SaleInfo {
                    OrderId = 10624,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3240,
                    Date = DateTime.Parse("2014/06/20")
                },
                new SaleInfo {
                    OrderId = 10625,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3180,
                    Date = DateTime.Parse("2014/06/23")
                },
                new SaleInfo {
                    OrderId = 10626,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 780,
                    Date = DateTime.Parse("2014/06/13")
                },
                new SaleInfo {
                    OrderId = 10627,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 4680,
                    Date = DateTime.Parse("2014/06/08")
                },
                new SaleInfo {
                    OrderId = 10628,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 2475,
                    Date = DateTime.Parse("2014/06/25")
                },
                new SaleInfo {
                    OrderId = 10629,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1920,
                    Date = DateTime.Parse("2014/06/20")
                },
                new SaleInfo {
                    OrderId = 10630,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 7500,
                    Date = DateTime.Parse("2014/06/25")
                },
                new SaleInfo {
                    OrderId = 10631,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5025,
                    Date = DateTime.Parse("2014/06/26")
                },
                new SaleInfo {
                    OrderId = 10632,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2400,
                    Date = DateTime.Parse("2014/06/08")
                },
                new SaleInfo {
                    OrderId = 10633,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1720,
                    Date = DateTime.Parse("2014/06/09")
                },
                new SaleInfo {
                    OrderId = 10634,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 2880,
                    Date = DateTime.Parse("2014/06/21")
                },
                new SaleInfo {
                    OrderId = 10635,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 5430,
                    Date = DateTime.Parse("2014/06/03")
                },
                new SaleInfo {
                    OrderId = 10636,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4475,
                    Date = DateTime.Parse("2014/06/19")
                },
                new SaleInfo {
                    OrderId = 10637,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 1420,
                    Date = DateTime.Parse("2014/06/20")
                },
                new SaleInfo {
                    OrderId = 10638,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2670,
                    Date = DateTime.Parse("2014/06/25")
                },
                new SaleInfo {
                    OrderId = 10639,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1930,
                    Date = DateTime.Parse("2014/06/02")
                },
                new SaleInfo {
                    OrderId = 10640,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 580,
                    Date = DateTime.Parse("2014/06/25")
                },
                new SaleInfo {
                    OrderId = 10641,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1620,
                    Date = DateTime.Parse("2014/06/12")
                },
                new SaleInfo {
                    OrderId = 10642,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4530,
                    Date = DateTime.Parse("2014/06/02")
                },
                new SaleInfo {
                    OrderId = 10643,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 6025,
                    Date = DateTime.Parse("2014/06/23")
                },
                new SaleInfo {
                    OrderId = 10644,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 3540,
                    Date = DateTime.Parse("2014/07/21")
                },
                new SaleInfo {
                    OrderId = 10645,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 3000,
                    Date = DateTime.Parse("2014/07/01")
                },
                new SaleInfo {
                    OrderId = 10646,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3240,
                    Date = DateTime.Parse("2014/07/26")
                },
                new SaleInfo {
                    OrderId = 10647,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2265,
                    Date = DateTime.Parse("2014/07/22")
                },
                new SaleInfo {
                    OrderId = 10648,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 400,
                    Date = DateTime.Parse("2014/07/09")
                },
                new SaleInfo {
                    OrderId = 10649,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 1460,
                    Date = DateTime.Parse("2014/07/08")
                },
                new SaleInfo {
                    OrderId = 10650,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1620,
                    Date = DateTime.Parse("2014/07/18")
                },
                new SaleInfo {
                    OrderId = 10651,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2400,
                    Date = DateTime.Parse("2014/07/25")
                },
                new SaleInfo {
                    OrderId = 10652,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 5275,
                    Date = DateTime.Parse("2014/07/04")
                },
                new SaleInfo {
                    OrderId = 10653,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 4475,
                    Date = DateTime.Parse("2014/07/03")
                },
                new SaleInfo {
                    OrderId = 10654,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 3980,
                    Date = DateTime.Parse("2014/07/21")
                },
                new SaleInfo {
                    OrderId = 10655,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 5240,
                    Date = DateTime.Parse("2014/07/11")
                },
                new SaleInfo {
                    OrderId = 10656,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 1200,
                    Date = DateTime.Parse("2014/07/21")
                },
                new SaleInfo {
                    OrderId = 10657,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 5700,
                    Date = DateTime.Parse("2014/07/18")
                },
                new SaleInfo {
                    OrderId = 10658,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 5575,
                    Date = DateTime.Parse("2014/07/01")
                },
                new SaleInfo {
                    OrderId = 10659,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 2160,
                    Date = DateTime.Parse("2014/07/02")
                },
                new SaleInfo {
                    OrderId = 10660,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 960,
                    Date = DateTime.Parse("2014/07/09")
                },
                new SaleInfo {
                    OrderId = 10661,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1280,
                    Date = DateTime.Parse("2014/07/04")
                },
                new SaleInfo {
                    OrderId = 10662,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1040,
                    Date = DateTime.Parse("2014/07/02")
                },
                new SaleInfo {
                    OrderId = 10663,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 5520,
                    Date = DateTime.Parse("2014/07/21")
                },
                new SaleInfo {
                    OrderId = 10664,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1760,
                    Date = DateTime.Parse("2014/07/25")
                },
                new SaleInfo {
                    OrderId = 10665,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 4080,
                    Date = DateTime.Parse("2014/07/07")
                },
                new SaleInfo {
                    OrderId = 10666,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1000,
                    Date = DateTime.Parse("2014/07/21")
                },
                new SaleInfo {
                    OrderId = 10667,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 3270,
                    Date = DateTime.Parse("2014/07/12")
                },
                new SaleInfo {
                    OrderId = 10668,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 1770,
                    Date = DateTime.Parse("2014/08/23")
                },
                new SaleInfo {
                    OrderId = 10669,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 2700,
                    Date = DateTime.Parse("2014/08/09")
                },
                new SaleInfo {
                    OrderId = 10670,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2175,
                    Date = DateTime.Parse("2014/08/03")
                },
                new SaleInfo {
                    OrderId = 10671,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3375,
                    Date = DateTime.Parse("2014/08/11")
                },
                new SaleInfo {
                    OrderId = 10672,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2040,
                    Date = DateTime.Parse("2014/08/01")
                },
                new SaleInfo {
                    OrderId = 10673,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 3000,
                    Date = DateTime.Parse("2014/08/21")
                },
                new SaleInfo {
                    OrderId = 10674,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 3900,
                    Date = DateTime.Parse("2014/08/16")
                },
                new SaleInfo {
                    OrderId = 10675,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1370,
                    Date = DateTime.Parse("2014/08/20")
                },
                new SaleInfo {
                    OrderId = 10676,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 5700,
                    Date = DateTime.Parse("2014/08/01")
                },
                new SaleInfo {
                    OrderId = 10677,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 1275,
                    Date = DateTime.Parse("2014/08/22")
                },
                new SaleInfo {
                    OrderId = 10678,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 4060,
                    Date = DateTime.Parse("2014/08/13")
                },
                new SaleInfo {
                    OrderId = 10679,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2320,
                    Date = DateTime.Parse("2014/08/18")
                },
                new SaleInfo {
                    OrderId = 10680,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 7590,
                    Date = DateTime.Parse("2014/08/24")
                },
                new SaleInfo {
                    OrderId = 10681,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 4560,
                    Date = DateTime.Parse("2014/08/20")
                },
                new SaleInfo {
                    OrderId = 10682,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 7575,
                    Date = DateTime.Parse("2014/08/20")
                },
                new SaleInfo {
                    OrderId = 10683,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 700,
                    Date = DateTime.Parse("2014/08/25")
                },
                new SaleInfo {
                    OrderId = 10684,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2400,
                    Date = DateTime.Parse("2014/08/16")
                },
                new SaleInfo {
                    OrderId = 10685,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1390,
                    Date = DateTime.Parse("2014/08/15")
                },
                new SaleInfo {
                    OrderId = 10686,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1320,
                    Date = DateTime.Parse("2014/08/09")
                },
                new SaleInfo {
                    OrderId = 10687,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 1680,
                    Date = DateTime.Parse("2014/08/09")
                },
                new SaleInfo {
                    OrderId = 10688,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1500,
                    Date = DateTime.Parse("2014/08/11")
                },
                new SaleInfo {
                    OrderId = 10689,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 6150,
                    Date = DateTime.Parse("2014/09/21")
                },
                new SaleInfo {
                    OrderId = 10690,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 3675,
                    Date = DateTime.Parse("2014/09/02")
                },
                new SaleInfo {
                    OrderId = 10691,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 2250,
                    Date = DateTime.Parse("2014/09/05")
                },
                new SaleInfo {
                    OrderId = 10692,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 3585,
                    Date = DateTime.Parse("2014/09/10")
                },
                new SaleInfo {
                    OrderId = 10693,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1470,
                    Date = DateTime.Parse("2014/09/01")
                },
                new SaleInfo {
                    OrderId = 10694,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2260,
                    Date = DateTime.Parse("2014/09/02")
                },
                new SaleInfo {
                    OrderId = 10695,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 3765,
                    Date = DateTime.Parse("2014/09/03")
                },
                new SaleInfo {
                    OrderId = 10696,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1640,
                    Date = DateTime.Parse("2014/09/04")
                },
                new SaleInfo {
                    OrderId = 10697,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 4475,
                    Date = DateTime.Parse("2014/09/09")
                },
                new SaleInfo {
                    OrderId = 10698,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5975,
                    Date = DateTime.Parse("2014/09/04")
                },
                new SaleInfo {
                    OrderId = 10699,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 1100,
                    Date = DateTime.Parse("2014/09/16")
                },
                new SaleInfo {
                    OrderId = 10700,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1320,
                    Date = DateTime.Parse("2014/09/18")
                },
                new SaleInfo {
                    OrderId = 10701,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8610,
                    Date = DateTime.Parse("2014/09/19")
                },
                new SaleInfo {
                    OrderId = 10702,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 9210,
                    Date = DateTime.Parse("2014/09/09")
                },
                new SaleInfo {
                    OrderId = 10703,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3700,
                    Date = DateTime.Parse("2014/09/01")
                },
                new SaleInfo {
                    OrderId = 10704,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 3620,
                    Date = DateTime.Parse("2014/09/19")
                },
                new SaleInfo {
                    OrderId = 10705,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4275,
                    Date = DateTime.Parse("2014/09/01")
                },
                new SaleInfo {
                    OrderId = 10706,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2370,
                    Date = DateTime.Parse("2014/09/03")
                },
                new SaleInfo {
                    OrderId = 10707,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1870,
                    Date = DateTime.Parse("2014/09/10")
                },
                new SaleInfo {
                    OrderId = 10708,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2070,
                    Date = DateTime.Parse("2014/09/25")
                },
                new SaleInfo {
                    OrderId = 10709,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5025,
                    Date = DateTime.Parse("2014/09/19")
                },
                new SaleInfo {
                    OrderId = 10710,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 1080,
                    Date = DateTime.Parse("2014/10/15")
                },
                new SaleInfo {
                    OrderId = 10711,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 1400,
                    Date = DateTime.Parse("2014/10/22")
                },
                new SaleInfo {
                    OrderId = 10712,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 4260,
                    Date = DateTime.Parse("2014/10/01")
                },
                new SaleInfo {
                    OrderId = 10713,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 2745,
                    Date = DateTime.Parse("2014/10/01")
                },
                new SaleInfo {
                    OrderId = 10714,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2920,
                    Date = DateTime.Parse("2014/10/23")
                },
                new SaleInfo {
                    OrderId = 10715,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 3520,
                    Date = DateTime.Parse("2014/10/11")
                },
                new SaleInfo {
                    OrderId = 10716,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4035,
                    Date = DateTime.Parse("2014/10/20")
                },
                new SaleInfo {
                    OrderId = 10717,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1730,
                    Date = DateTime.Parse("2014/10/05")
                },
                new SaleInfo {
                    OrderId = 10718,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 975,
                    Date = DateTime.Parse("2014/10/06")
                },
                new SaleInfo {
                    OrderId = 10719,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5700,
                    Date = DateTime.Parse("2014/10/06")
                },
                new SaleInfo {
                    OrderId = 10720,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5080,
                    Date = DateTime.Parse("2014/10/18")
                },
                new SaleInfo {
                    OrderId = 10721,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2940,
                    Date = DateTime.Parse("2014/10/24")
                },
                new SaleInfo {
                    OrderId = 10722,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 2670,
                    Date = DateTime.Parse("2014/10/04")
                },
                new SaleInfo {
                    OrderId = 10723,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1230,
                    Date = DateTime.Parse("2014/10/11")
                },
                new SaleInfo {
                    OrderId = 10724,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 600,
                    Date = DateTime.Parse("2014/10/08")
                },
                new SaleInfo {
                    OrderId = 10725,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 3700,
                    Date = DateTime.Parse("2014/10/08")
                },
                new SaleInfo {
                    OrderId = 10726,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3375,
                    Date = DateTime.Parse("2014/10/11")
                },
                new SaleInfo {
                    OrderId = 10727,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1500,
                    Date = DateTime.Parse("2014/10/17")
                },
                new SaleInfo {
                    OrderId = 10728,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 370,
                    Date = DateTime.Parse("2014/10/05")
                },
                new SaleInfo {
                    OrderId = 10729,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2340,
                    Date = DateTime.Parse("2014/10/16")
                },
                new SaleInfo {
                    OrderId = 10730,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1080,
                    Date = DateTime.Parse("2014/10/08")
                },
                new SaleInfo {
                    OrderId = 10731,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 2775,
                    Date = DateTime.Parse("2014/10/21")
                },
                new SaleInfo {
                    OrderId = 10732,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 4380,
                    Date = DateTime.Parse("2014/11/09")
                },
                new SaleInfo {
                    OrderId = 10733,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 5500,
                    Date = DateTime.Parse("2014/11/21")
                },
                new SaleInfo {
                    OrderId = 10734,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 1920,
                    Date = DateTime.Parse("2014/11/24")
                },
                new SaleInfo {
                    OrderId = 10735,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 765,
                    Date = DateTime.Parse("2014/11/24")
                },
                new SaleInfo {
                    OrderId = 10736,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 370,
                    Date = DateTime.Parse("2014/11/18")
                },
                new SaleInfo {
                    OrderId = 10737,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 3500,
                    Date = DateTime.Parse("2014/11/25")
                },
                new SaleInfo {
                    OrderId = 10738,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 825,
                    Date = DateTime.Parse("2014/11/09")
                },
                new SaleInfo {
                    OrderId = 10739,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 490,
                    Date = DateTime.Parse("2014/11/23")
                },
                new SaleInfo {
                    OrderId = 10740,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 7075,
                    Date = DateTime.Parse("2014/11/20")
                },
                new SaleInfo {
                    OrderId = 10741,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 1350,
                    Date = DateTime.Parse("2014/11/25")
                },
                new SaleInfo {
                    OrderId = 10742,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 1440,
                    Date = DateTime.Parse("2014/11/15")
                },
                new SaleInfo {
                    OrderId = 10743,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2820,
                    Date = DateTime.Parse("2014/11/13")
                },
                new SaleInfo {
                    OrderId = 10744,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 2280,
                    Date = DateTime.Parse("2014/11/12")
                },
                new SaleInfo {
                    OrderId = 10745,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1110,
                    Date = DateTime.Parse("2014/11/03")
                },
                new SaleInfo {
                    OrderId = 10746,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 1150,
                    Date = DateTime.Parse("2014/11/23")
                },
                new SaleInfo {
                    OrderId = 10747,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 2040,
                    Date = DateTime.Parse("2014/11/20")
                },
                new SaleInfo {
                    OrderId = 10748,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3090,
                    Date = DateTime.Parse("2014/11/24")
                },
                new SaleInfo {
                    OrderId = 10749,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1940,
                    Date = DateTime.Parse("2014/11/24")
                },
                new SaleInfo {
                    OrderId = 10750,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 3090,
                    Date = DateTime.Parse("2014/11/16")
                },
                new SaleInfo {
                    OrderId = 10751,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4900,
                    Date = DateTime.Parse("2014/11/05")
                },
                new SaleInfo {
                    OrderId = 10752,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3465,
                    Date = DateTime.Parse("2014/11/07")
                },
                new SaleInfo {
                    OrderId = 10753,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1110,
                    Date = DateTime.Parse("2014/11/20")
                },
                new SaleInfo {
                    OrderId = 10754,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1650,
                    Date = DateTime.Parse("2014/11/02")
                },
                new SaleInfo {
                    OrderId = 10755,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 5280,
                    Date = DateTime.Parse("2014/12/04")
                },
                new SaleInfo {
                    OrderId = 10756,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 3075,
                    Date = DateTime.Parse("2014/12/02")
                },
                new SaleInfo {
                    OrderId = 10757,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 690,
                    Date = DateTime.Parse("2014/12/07")
                },
                new SaleInfo {
                    OrderId = 10758,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1305,
                    Date = DateTime.Parse("2014/12/15")
                },
                new SaleInfo {
                    OrderId = 10759,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1970,
                    Date = DateTime.Parse("2014/12/01")
                },
                new SaleInfo {
                    OrderId = 10760,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 3760,
                    Date = DateTime.Parse("2014/12/18")
                },
                new SaleInfo {
                    OrderId = 10761,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1920,
                    Date = DateTime.Parse("2014/12/22")
                },
                new SaleInfo {
                    OrderId = 10762,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1360,
                    Date = DateTime.Parse("2014/12/12")
                },
                new SaleInfo {
                    OrderId = 10763,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 2525,
                    Date = DateTime.Parse("2014/12/06")
                },
                new SaleInfo {
                    OrderId = 10764,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 5575,
                    Date = DateTime.Parse("2014/12/20")
                },
                new SaleInfo {
                    OrderId = 10765,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5560,
                    Date = DateTime.Parse("2014/12/10")
                },
                new SaleInfo {
                    OrderId = 10766,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 4880,
                    Date = DateTime.Parse("2014/12/13")
                },
                new SaleInfo {
                    OrderId = 10767,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8850,
                    Date = DateTime.Parse("2014/12/03")
                },
                new SaleInfo {
                    OrderId = 10768,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 2820,
                    Date = DateTime.Parse("2014/12/10")
                },
                new SaleInfo {
                    OrderId = 10769,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 4000,
                    Date = DateTime.Parse("2014/12/12")
                },
                new SaleInfo {
                    OrderId = 10770,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 5820,
                    Date = DateTime.Parse("2014/12/02")
                },
                new SaleInfo {
                    OrderId = 10771,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 1275,
                    Date = DateTime.Parse("2014/12/12")
                },
                new SaleInfo {
                    OrderId = 10772,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1310,
                    Date = DateTime.Parse("2014/12/01")
                },
                new SaleInfo {
                    OrderId = 10773,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2180,
                    Date = DateTime.Parse("2014/12/26")
                },
                new SaleInfo {
                    OrderId = 10774,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4470,
                    Date = DateTime.Parse("2014/12/17")
                },
                new SaleInfo {
                    OrderId = 10775,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2990,
                    Date = DateTime.Parse("2014/12/15")
                },
                new SaleInfo {
                    OrderId = 10776,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 7650,
                    Date = DateTime.Parse("2014/12/18")
                },
                new SaleInfo {
                    OrderId = 10777,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 780,
                    Date = DateTime.Parse("2014/12/02")
                },
                new SaleInfo {
                    OrderId = 10778,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2970,
                    Date = DateTime.Parse("2014/12/13")
                },
                new SaleInfo {
                    OrderId = 10779,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1155,
                    Date = DateTime.Parse("2014/12/05")
                },
                new SaleInfo {
                    OrderId = 10780,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 4470,
                    Date = DateTime.Parse("2015/01/10")
                },
                new SaleInfo {
                    OrderId = 10781,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 1125,
                    Date = DateTime.Parse("2015/01/21")
                },
                new SaleInfo {
                    OrderId = 10782,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 645,
                    Date = DateTime.Parse("2015/01/17")
                },
                new SaleInfo {
                    OrderId = 10783,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 675,
                    Date = DateTime.Parse("2015/01/05")
                },
                new SaleInfo {
                    OrderId = 10784,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2840,
                    Date = DateTime.Parse("2015/01/05")
                },
                new SaleInfo {
                    OrderId = 10785,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2660,
                    Date = DateTime.Parse("2015/01/04")
                },
                new SaleInfo {
                    OrderId = 10786,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4560,
                    Date = DateTime.Parse("2015/01/12")
                },
                new SaleInfo {
                    OrderId = 10787,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2880,
                    Date = DateTime.Parse("2015/01/20")
                },
                new SaleInfo {
                    OrderId = 10788,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 500,
                    Date = DateTime.Parse("2015/01/02")
                },
                new SaleInfo {
                    OrderId = 10789,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 3925,
                    Date = DateTime.Parse("2015/01/07")
                },
                new SaleInfo {
                    OrderId = 10790,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5660,
                    Date = DateTime.Parse("2015/01/18")
                },
                new SaleInfo {
                    OrderId = 10791,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1460,
                    Date = DateTime.Parse("2015/01/22")
                },
                new SaleInfo {
                    OrderId = 10792,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 5040,
                    Date = DateTime.Parse("2015/01/10")
                },
                new SaleInfo {
                    OrderId = 10793,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 4830,
                    Date = DateTime.Parse("2015/01/13")
                },
                new SaleInfo {
                    OrderId = 10794,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3075,
                    Date = DateTime.Parse("2015/01/22")
                },
                new SaleInfo {
                    OrderId = 10795,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 3120,
                    Date = DateTime.Parse("2015/01/14")
                },
                new SaleInfo {
                    OrderId = 10796,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3525,
                    Date = DateTime.Parse("2015/01/23")
                },
                new SaleInfo {
                    OrderId = 10797,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1930,
                    Date = DateTime.Parse("2015/01/09")
                },
                new SaleInfo {
                    OrderId = 10798,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2890,
                    Date = DateTime.Parse("2015/01/02")
                },
                new SaleInfo {
                    OrderId = 10799,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 1545,
                    Date = DateTime.Parse("2015/01/17")
                },
                new SaleInfo {
                    OrderId = 10800,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3630,
                    Date = DateTime.Parse("2015/01/20")
                },
                new SaleInfo {
                    OrderId = 10801,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 4035,
                    Date = DateTime.Parse("2015/01/14")
                },
                new SaleInfo {
                    OrderId = 10802,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 345,
                    Date = DateTime.Parse("2015/01/06")
                },
                new SaleInfo {
                    OrderId = 10803,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 7000,
                    Date = DateTime.Parse("2015/01/07")
                },
                new SaleInfo {
                    OrderId = 10804,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 3060,
                    Date = DateTime.Parse("2015/02/13")
                },
                new SaleInfo {
                    OrderId = 10805,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 6425,
                    Date = DateTime.Parse("2015/02/04")
                },
                new SaleInfo {
                    OrderId = 10806,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 615,
                    Date = DateTime.Parse("2015/02/22")
                },
                new SaleInfo {
                    OrderId = 10807,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1755,
                    Date = DateTime.Parse("2015/02/07")
                },
                new SaleInfo {
                    OrderId = 10808,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1540,
                    Date = DateTime.Parse("2015/02/21")
                },
                new SaleInfo {
                    OrderId = 10809,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 2820,
                    Date = DateTime.Parse("2015/02/24")
                },
                new SaleInfo {
                    OrderId = 10810,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4305,
                    Date = DateTime.Parse("2015/02/10")
                },
                new SaleInfo {
                    OrderId = 10811,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 1520,
                    Date = DateTime.Parse("2015/02/26")
                },
                new SaleInfo {
                    OrderId = 10812,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 4725,
                    Date = DateTime.Parse("2015/02/18")
                },
                new SaleInfo {
                    OrderId = 10813,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 6750,
                    Date = DateTime.Parse("2015/02/16")
                },
                new SaleInfo {
                    OrderId = 10814,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 5540,
                    Date = DateTime.Parse("2015/02/07")
                },
                new SaleInfo {
                    OrderId = 10815,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1880,
                    Date = DateTime.Parse("2015/02/24")
                },
                new SaleInfo {
                    OrderId = 10816,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 6180,
                    Date = DateTime.Parse("2015/02/26")
                },
                new SaleInfo {
                    OrderId = 10817,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 9300,
                    Date = DateTime.Parse("2015/02/03")
                },
                new SaleInfo {
                    OrderId = 10818,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3700,
                    Date = DateTime.Parse("2015/02/26")
                },
                new SaleInfo {
                    OrderId = 10819,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 740,
                    Date = DateTime.Parse("2015/02/01")
                },
                new SaleInfo {
                    OrderId = 10820,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4755,
                    Date = DateTime.Parse("2015/02/23")
                },
                new SaleInfo {
                    OrderId = 10821,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2570,
                    Date = DateTime.Parse("2015/02/20")
                },
                new SaleInfo {
                    OrderId = 10822,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 2860,
                    Date = DateTime.Parse("2015/02/19")
                },
                new SaleInfo {
                    OrderId = 10823,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 5430,
                    Date = DateTime.Parse("2015/03/21")
                },
                new SaleInfo {
                    OrderId = 10824,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 4525,
                    Date = DateTime.Parse("2015/03/21")
                },
                new SaleInfo {
                    OrderId = 10825,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 1515,
                    Date = DateTime.Parse("2015/03/10")
                },
                new SaleInfo {
                    OrderId = 10826,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 630,
                    Date = DateTime.Parse("2015/03/15")
                },
                new SaleInfo {
                    OrderId = 10827,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1310,
                    Date = DateTime.Parse("2015/03/01")
                },
                new SaleInfo {
                    OrderId = 10828,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 3200,
                    Date = DateTime.Parse("2015/03/17")
                },
                new SaleInfo {
                    OrderId = 10829,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 3945,
                    Date = DateTime.Parse("2015/03/20")
                },
                new SaleInfo {
                    OrderId = 10830,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2990,
                    Date = DateTime.Parse("2015/03/18")
                },
                new SaleInfo {
                    OrderId = 10831,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 1125,
                    Date = DateTime.Parse("2015/03/22")
                },
                new SaleInfo {
                    OrderId = 10832,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 7950,
                    Date = DateTime.Parse("2015/03/17")
                },
                new SaleInfo {
                    OrderId = 10833,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 2960,
                    Date = DateTime.Parse("2015/03/25")
                },
                new SaleInfo {
                    OrderId = 10834,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 6300,
                    Date = DateTime.Parse("2015/03/20")
                },
                new SaleInfo {
                    OrderId = 10835,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 8670,
                    Date = DateTime.Parse("2015/03/07")
                },
                new SaleInfo {
                    OrderId = 10836,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 3930,
                    Date = DateTime.Parse("2015/03/23")
                },
                new SaleInfo {
                    OrderId = 10837,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 6975,
                    Date = DateTime.Parse("2015/03/02")
                },
                new SaleInfo {
                    OrderId = 10838,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4220,
                    Date = DateTime.Parse("2015/03/17")
                },
                new SaleInfo {
                    OrderId = 10839,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 3090,
                    Date = DateTime.Parse("2015/03/25")
                },
                new SaleInfo {
                    OrderId = 10840,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2380,
                    Date = DateTime.Parse("2015/03/01")
                },
                new SaleInfo {
                    OrderId = 10841,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1510,
                    Date = DateTime.Parse("2015/03/07")
                },
                new SaleInfo {
                    OrderId = 10842,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 1020,
                    Date = DateTime.Parse("2015/03/19")
                },
                new SaleInfo {
                    OrderId = 10843,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 6700,
                    Date = DateTime.Parse("2015/03/26")
                },
                new SaleInfo {
                    OrderId = 10844,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 4890,
                    Date = DateTime.Parse("2015/04/02")
                },
                new SaleInfo {
                    OrderId = 10845,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 7225,
                    Date = DateTime.Parse("2015/04/13")
                },
                new SaleInfo {
                    OrderId = 10846,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 795,
                    Date = DateTime.Parse("2015/04/07")
                },
                new SaleInfo {
                    OrderId = 10847,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1785,
                    Date = DateTime.Parse("2015/04/03")
                },
                new SaleInfo {
                    OrderId = 10848,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1850,
                    Date = DateTime.Parse("2015/04/03")
                },
                new SaleInfo {
                    OrderId = 10849,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 5120,
                    Date = DateTime.Parse("2015/04/12")
                },
                new SaleInfo {
                    OrderId = 10850,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 615,
                    Date = DateTime.Parse("2015/04/07")
                },
                new SaleInfo {
                    OrderId = 10851,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2860,
                    Date = DateTime.Parse("2015/04/05")
                },
                new SaleInfo {
                    OrderId = 10852,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 1525,
                    Date = DateTime.Parse("2015/04/24")
                },
                new SaleInfo {
                    OrderId = 10853,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 7425,
                    Date = DateTime.Parse("2015/04/15")
                },
                new SaleInfo {
                    OrderId = 10854,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 6080,
                    Date = DateTime.Parse("2015/04/13")
                },
                new SaleInfo {
                    OrderId = 10855,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 2940,
                    Date = DateTime.Parse("2015/04/04")
                },
                new SaleInfo {
                    OrderId = 10856,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 5580,
                    Date = DateTime.Parse("2015/04/16")
                },
                new SaleInfo {
                    OrderId = 10857,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 9390,
                    Date = DateTime.Parse("2015/04/19")
                },
                new SaleInfo {
                    OrderId = 10858,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3200,
                    Date = DateTime.Parse("2015/04/26")
                },
                new SaleInfo {
                    OrderId = 10859,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4380,
                    Date = DateTime.Parse("2015/04/05")
                },
                new SaleInfo {
                    OrderId = 10860,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 4725,
                    Date = DateTime.Parse("2015/04/06")
                },
                new SaleInfo {
                    OrderId = 10861,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 930,
                    Date = DateTime.Parse("2015/04/25")
                },
                new SaleInfo {
                    OrderId = 10862,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 1910,
                    Date = DateTime.Parse("2015/04/05")
                },
                new SaleInfo {
                    OrderId = 10863,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 2725,
                    Date = DateTime.Parse("2015/04/16")
                },
                new SaleInfo {
                    OrderId = 10864,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 4720,
                    Date = DateTime.Parse("2015/04/02")
                },
                new SaleInfo {
                    OrderId = 10865,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 5190,
                    Date = DateTime.Parse("2015/04/10")
                },
                new SaleInfo {
                    OrderId = 10866,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 2800,
                    Date = DateTime.Parse("2015/04/26")
                },
                new SaleInfo {
                    OrderId = 10867,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 3780,
                    Date = DateTime.Parse("2015/04/24")
                },
                new SaleInfo {
                    OrderId = 10868,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 2340,
                    Date = DateTime.Parse("2015/04/17")
                },
                new SaleInfo {
                    OrderId = 10869,
                    Region = "North America",
                    Country = "United States",
                    City = "New York",
                    Amount = 4830,
                    Date = DateTime.Parse("2015/05/12")
                },
                new SaleInfo {
                    OrderId = 10870,
                    Region = "North America",
                    Country = "United States",
                    City = "Los Angeles",
                    Amount = 2075,
                    Date = DateTime.Parse("2015/05/23")
                },
                new SaleInfo {
                    OrderId = 10871,
                    Region = "North America",
                    Country = "United States",
                    City = "Denver",
                    Amount = 3420,
                    Date = DateTime.Parse("2015/05/21")
                },
                new SaleInfo {
                    OrderId = 10872,
                    Region = "North America",
                    Country = "Canada",
                    City = "Vancouver",
                    Amount = 1440,
                    Date = DateTime.Parse("2015/05/10")
                },
                new SaleInfo {
                    OrderId = 10873,
                    Region = "North America",
                    Country = "Canada",
                    City = "Edmonton",
                    Amount = 1680,
                    Date = DateTime.Parse("2015/05/15")
                },
                new SaleInfo {
                    OrderId = 10874,
                    Region = "South America",
                    Country = "Brazil",
                    City = "Rio de Janeiro",
                    Amount = 3440,
                    Date = DateTime.Parse("2015/05/16")
                },
                new SaleInfo {
                    OrderId = 10875,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 4695,
                    Date = DateTime.Parse("2015/05/10")
                },
                new SaleInfo {
                    OrderId = 10876,
                    Region = "South America",
                    Country = "Paraguay",
                    City = "Asuncion",
                    Amount = 2380,
                    Date = DateTime.Parse("2015/05/06")
                },
                new SaleInfo {
                    OrderId = 10877,
                    Region = "Europe",
                    Country = "United Kingdom",
                    City = "London",
                    Amount = 1875,
                    Date = DateTime.Parse("2015/05/25")
                },
                new SaleInfo {
                    OrderId = 10878,
                    Region = "Europe",
                    Country = "Germany",
                    City = "Berlin",
                    Amount = 7550,
                    Date = DateTime.Parse("2015/05/14")
                },
                new SaleInfo {
                    OrderId = 10879,
                    Region = "Europe",
                    Country = "Spain",
                    City = "Madrid",
                    Amount = 3340,
                    Date = DateTime.Parse("2015/05/01")
                },
                new SaleInfo {
                    OrderId = 10880,
                    Region = "Europe",
                    Country = "Russian Federation",
                    City = "Moscow",
                    Amount = 1400,
                    Date = DateTime.Parse("2015/05/22")
                },
                new SaleInfo {
                    OrderId = 10881,
                    Region = "Asia",
                    Country = "China",
                    City = "Beijing",
                    Amount = 6060,
                    Date = DateTime.Parse("2015/05/22")
                },
                new SaleInfo {
                    OrderId = 10882,
                    Region = "Asia",
                    Country = "Japan",
                    City = "Tokyo",
                    Amount = 8370,
                    Date = DateTime.Parse("2015/05/13")
                },
                new SaleInfo {
                    OrderId = 10883,
                    Region = "Asia",
                    Country = "Republic of Korea",
                    City = "Seoul",
                    Amount = 3550,
                    Date = DateTime.Parse("2015/05/26")
                },
                new SaleInfo {
                    OrderId = 10884,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Sydney",
                    Amount = 2620,
                    Date = DateTime.Parse("2015/05/17")
                },
                new SaleInfo {
                    OrderId = 10885,
                    Region = "Australia",
                    Country = "Australia",
                    City = "Melbourne",
                    Amount = 2400,
                    Date = DateTime.Parse("2015/05/21")
                },
                new SaleInfo {
                    OrderId = 10886,
                    Region = "Africa",
                    Country = "South Africa",
                    City = "Pretoria",
                    Amount = 1740,
                    Date = DateTime.Parse("2015/05/21")
                },
                new SaleInfo {
                    OrderId = 10887,
                    Region = "Africa",
                    Country = "Egypt",
                    City = "Cairo",
                    Amount = 500,
                    Date = DateTime.Parse("2015/05/26")
                },
                new SaleInfo {
                    OrderId = 10888,
                    Region = "South America",
                    Country = "Argentina",
                    City = "Buenos Aires",
                    Amount = 780,
                    Date = DateTime.Parse("2015/05/07")
                }
            };
        }
        public static Task<IQueryable<SaleInfo>> Load()
        {
            return Task.FromResult(dataSource.AsQueryable());
        }
    }
}