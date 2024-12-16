using System.Collections.Generic;
using BlazorDemo.Data;

namespace BlazorDemo.DataProviders.Implementation {
    public class SalesAmountDataProvider : ISalesAmountDataProvider {
        public List<SalesAmountData> GenerateData() {

            return new List<SalesAmountData>() {
                new SalesAmountData(2015, "Cameras", 260.04),
                new SalesAmountData(2016, "Cameras", 323.40),
                new SalesAmountData(2017, "Cameras", 252.72),
                new SalesAmountData(2018, "Cameras", 457.00),
                new SalesAmountData(2019, "Cameras", 201.44),
                new SalesAmountData(2020, "Cameras", 93.95),
                new SalesAmountData(2021, "Cameras", 104.92),
                new SalesAmountData(2022, "Cameras", 65.47),
                new SalesAmountData(2023, "Cameras", 225.98),

                new SalesAmountData(2015, "Cell Phones", 430.04),
                new SalesAmountData(2016, "Cell Phones", 162.11),
                new SalesAmountData(2017, "Cell Phones", 332.04),
                new SalesAmountData(2018, "Cell Phones", 216.42),
                new SalesAmountData(2019, "Cell Phones", 174.20),
                new SalesAmountData(2020, "Cell Phones", 410.99),
                new SalesAmountData(2021, "Cell Phones", 494.10),
                new SalesAmountData(2022, "Cell Phones", 139.42),
                new SalesAmountData(2023, "Cell Phones", 416.96),

                new SalesAmountData(2015, "Computers", 496.50),
                new SalesAmountData(2016, "Computers", 186.91),
                new SalesAmountData(2017, "Computers", 53.18),
                new SalesAmountData(2018, "Computers", 181.05),
                new SalesAmountData(2019, "Computers", 229.94),
                new SalesAmountData(2020, "Computers", 181.47),
                new SalesAmountData(2021, "Computers", 255.23),
                new SalesAmountData(2022, "Computers", 328.27),
                new SalesAmountData(2023, "Computers", 281.41),

                new SalesAmountData(2015, "TV, Audio", 348.14),
                new SalesAmountData(2016, "TV, Audio", 241.32),
                new SalesAmountData(2017, "TV, Audio", 305.47),
                new SalesAmountData(2018, "TV, Audio", 486.31),
                new SalesAmountData(2019, "TV, Audio", 252.39),
                new SalesAmountData(2020, "TV, Audio", 452.67),
                new SalesAmountData(2021, "TV, Audio", 464.84),
                new SalesAmountData(2022, "TV, Audio", 306.70),
                new SalesAmountData(2023, "TV, Audio", 70.35),

                new SalesAmountData(2015, "Vehicle Electronics", 218.54),
                new SalesAmountData(2016, "Vehicle Electronics", 132.55),
                new SalesAmountData(2017, "Vehicle Electronics", 120.21),
                new SalesAmountData(2018, "Vehicle Electronics", 94.99),
                new SalesAmountData(2019, "Vehicle Electronics", 439.78),
                new SalesAmountData(2020, "Vehicle Electronics", 114.29),
                new SalesAmountData(2021, "Vehicle Electronics", 59.26),
                new SalesAmountData(2022, "Vehicle Electronics", 374.90),
                new SalesAmountData(2023, "Vehicle Electronics", 145.55)
            };
        }
    }
}
