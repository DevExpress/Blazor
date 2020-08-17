using System;

namespace Demo.Blazor.Reports.CachedDocumentSource {
    public class Adjustment {
        public static Adjustment CreateBalanceForward(DateTime dt, int random) {
            var rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.date = dt;
            res.description = "Balance Forward";
            res.amount = rnd.Random(10, 300) * 10;
            return res;
        }
        public static Adjustment CreatePayment(DateTime dt, int random) {
            var rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.date = dt;
            res.description = "Payment";
            res.amount = -rnd.Random(1, 40) * 10;
            return res;
        }
        public static Adjustment CreateCharge(DateTime dt, int random) {
            var rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.date = dt;
            res.description = rnd.GetRandomItem(bills);
            res.amount = rnd.Random(10, 50) * 10;
            return res;
        }

        DateTime date;
        string description = "";
        double amount = 0;
        static string[] bills = new string[] { "Bill - Insurance", "Bill - Electricity", "Bill - Rent", "Bill - Phone", "Bill - Office Supplies" };
        public DateTime Date { get { return date; } }
        public string Description { get { return description; } }
        public double Amount { get { return amount; } }

        public Adjustment() {
        }
    }
}
