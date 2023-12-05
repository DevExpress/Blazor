namespace BlazorDemo.Data {
    public class BirthLife {
        public int Year { get; set; }
        public string Country { get; set; }
        public double BirthRate { get; set; }
        public double LifeExp { get; set; }

        public BirthLife(int year, string country, double birthRate, double lifeExp) {
            Year = year;
            Country = country;
            BirthRate = birthRate;
            LifeExp = lifeExp;
        }
    }
}
