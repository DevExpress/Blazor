using System;
using System.Collections.Generic;

namespace Demo.Blazor.Reports.ProfitAndLoss {
    public class Data {
        static List<Data> data;

        public DateTime Month { get; set; }

        public decimal ConstructionIncome { get; set; }
        public decimal SalesIncome { get; set; }

        public decimal CostOfGoodsSold { get; set; }
        public decimal JobExpenses { get; set; }

        public decimal Automobile { get; set; }
        public decimal BankServiceCharges { get; set; }
        public decimal Insurance { get; set; }
        public decimal PayrollExpenses { get; set; }
        public decimal Repairs { get; set; }
        public decimal ToolsAndMachinery { get; set; }

        static Random random = new Random(10041005);

        public static List<Data> GetData() {
            if(data == null)
                data = CreateData();
            return data;
        }

        public static List<Data> CreateData() {
            List<Data> data = new List<Data>();
            for(int i = 1; i <= 12; i++)
                data.Add(CreateItem(2018, i));
            return data;
        }
        static Data CreateItem(int year, int month) {
            return new Data() {
                Month = new DateTime(year, month, DateTime.DaysInMonth(year, month)),
                ConstructionIncome = random.Next(75000, 125000) + (decimal)random.NextDouble(),
                SalesIncome = random.Next(0, 1000),

                CostOfGoodsSold = random.Next(0, 3500) + (decimal)random.NextDouble(),
                JobExpenses = random.Next(5000, 35000) + (decimal)random.NextDouble(),

                Automobile = random.Next(300, 900) + (decimal)random.NextDouble(),
                BankServiceCharges = random.Next(10, 80),
                Insurance = random.Next(1000, 5000),
                PayrollExpenses = random.Next(9000, 18000),
                Repairs = random.Next(0, 400),
                ToolsAndMachinery = random.Next(0, 1000),
            };
        }

    }
}
