using System;
using System.Collections.Generic;
using BlazorDemo.Reports.CachedDocumentSourceReport;

namespace BlazorDemo.Reports.ProfitAndLossReport {
    public class Data {
        static List<Data> currentData;

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

        public static List<Data> GetData() {
            if(currentData == null)
                currentData = CreateData();
            return currentData;
        }
        static List<Data> CreateData() {
            List<Data> result = new List<Data>();
            for(int i = 1; i <= 12; i++)
                result.Add(CreateItem(2018, i));
            return result;
        }
        static Data CreateItem(int year, int month) {
            DeterministicRandom rnd = new DeterministicRandom(month);
            return new Data() {
                Month = new DateTime(year, month, DateTime.DaysInMonth(year, month)),
                ConstructionIncome = rnd.Random(75000, 125000) + (decimal)rnd.Random(100) / 100,
                SalesIncome = rnd.Random(0, 1000),

                CostOfGoodsSold = rnd.Random(0, 3500) + (decimal)rnd.Random(100) / 100,
                JobExpenses = rnd.Random(5000, 35000) + (decimal)rnd.Random(100) / 100,

                Automobile = rnd.Random(300, 900) + (decimal)rnd.Random(100) / 100,
                BankServiceCharges = rnd.Random(10, 80),
                Insurance = rnd.Random(1000, 5000),
                PayrollExpenses = rnd.Random(9000, 18000),
                Repairs = rnd.Random(0, 400),
                ToolsAndMachinery = rnd.Random(0, 1000),
            };
        }
    }
}
