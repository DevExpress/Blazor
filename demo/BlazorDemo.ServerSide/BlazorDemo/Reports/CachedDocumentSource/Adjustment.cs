using System;

namespace BlazorDemo.Reports.CachedDocumentSourceReport {
    public class Adjustment {
        public static Adjustment CreateBalanceForward(DateTime dt, int random) {
            var rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.currentDateTime = dt;
            res.currentDescription = "Balance Forward";
            res.currentAmount = rnd.Random(10, 300) * 10;
            return res;
        }
        public static Adjustment CreatePayment(DateTime dt, int random) {
            var rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.currentDateTime = dt;
            res.currentDescription = "Payment";
            res.currentAmount = -rnd.Random(1, 40) * 10;
            return res;
        }
        public static Adjustment CreateCharge(DateTime dt, int random) {
            var rnd = new DeterministicRandom(random);
            Adjustment res = new Adjustment();
            res.currentDateTime = dt;
            res.currentDescription = rnd.GetRandomItem(bills);
            res.currentAmount = rnd.Random(10, 50) * 10;
            return res;
        }

        DateTime currentDateTime;
        string currentDescription = "";
        double currentAmount = 0;
        static readonly string[] bills = new string[] { "Bill - Insurance", "Bill - Electricity", "Bill - Rent", "Bill - Phone", "Bill - Office Supplies" };
        public DateTime Date { get { return currentDateTime; } }
        public string Description { get { return currentDescription; } }
        public double Amount { get { return currentAmount; } }

        public Adjustment() {
        }
    }
}
