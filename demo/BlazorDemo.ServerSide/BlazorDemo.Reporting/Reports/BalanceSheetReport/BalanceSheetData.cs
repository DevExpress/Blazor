using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Demo.Blazor.Reports.BalanceSheetReport {
    public class BalanceSheetDataItem {
        ItemType type;
        public string Type {
            get { return type == ItemType.Assets ? "Assets" : "Liabilities and Shareholders Equity"; }
        }
        public string SubType { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public DateTime Date { get; set; }
        public BalanceSheetDataItem(DateTime date, ItemType type, string subType, string name, double? value) {
            this.type = type;
            SubType = subType;
            Date = date;
            Name = name;
            Value = value;
        }
    }
    public enum ItemType { Assets, Liabilities }

    [DisplayName("Balance Sheet Report Data Source")]
    public class BalanceSheetData {
        public static List<BalanceSheetDataItem> GetData() {
            Random random = new Random(2147483);
            List<BalanceSheetDataItem> items = new List<BalanceSheetDataItem>();
            items.AddRange(FillItems(random));
            return items;
        }
        static IEnumerable<BalanceSheetDataItem> FillItems(Random random) {
            List<BalanceSheetDataItem> items = new List<BalanceSheetDataItem>();
            for(int i = 0; i < 3; i++) {
                int year = DateTime.Today.Year - i;
                for(int month = 1; month <= 12; month++) {
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Cash and cash equivalents", GetRandomValue(random, 300, 2350));
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Marketable securities", GetRandomValue(random, 200, 3200));
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Accounts receivable trade, less allowances for doubtful accounts", GetRandomValue(random, 200, 1600));
                    AddItem(items, year, month, ItemType.Assets, "Current assets", "Inventories", GetRandomValue(random, 0, 1200));

                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Property, plant and equipment, net", GetRandomValue(random, 600, 1950));
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Intangible assets, net", GetRandomValue(random, 1000, 3300));
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Goodwill", GetRandomValue(random, 950, 2500));
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Equity and long-term investments", GetRandomValue(random, 0, 1000));
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Defered taxes on income", GetRandomValue(random, 80, 1800));
                    AddItem(items, year, month, ItemType.Assets, "Long-term assets", "Other assets", GetRandomValue(random, 60, 630));

                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Loans and notes payable", GetRandomValue(random, 130, 750));
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Accounts payable", GetRandomValue(random, 280, 970));
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Accrued rebates, returns and promotions", GetRandomValue(random, 185, 733));
                    AddItem(items, year, month, ItemType.Liabilities, "Current liabilities", "Accrued taxes on income", GetRandomValue(random, 5, 750));

                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Long-term debt", GetRandomValue(random, 650, 1800));
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Deferred taxes on income", GetRandomValue(random, 90, 390));
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Employee related obligations", GetRandomValue(random, 150, 700));
                    AddItem(items, year, month, ItemType.Liabilities, "Long-term liabilities", "Other liabilities", GetRandomValue(random, 495, 995));

                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Preferred stock - without par value", null);
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Common stock - par value $1.00 per share", GetRandomValue(random, 100, 1200));
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Accumulated other comprehensive income", GetRandomValue(random, -950, 0));
                    AddItem(items, year, month, ItemType.Liabilities, "Shareholders equity", "Retained earnings", GetRandomValue(random, 800, 2500));
                }
            }
            return items;
        }
        static void AddItem(List<BalanceSheetDataItem> items, int year, int month, ItemType type, string subType, string name, double? value) {
            items.Add(new BalanceSheetDataItem(new DateTime(year, month, 1), type, subType, name, value));
        }
        static double GetRandomValue(Random random, int min, int max) {
            int intPart = random.Next(min, max);
            double floatPart = Math.Round(random.NextDouble(), 2);
            return intPart + floatPart;
        }
    }
}
