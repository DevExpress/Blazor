namespace BlazorDemo.Data {
    public class PopulationAgeStructureItem {
        public string AgeGroup { get; }
        public string Gender { get; }
        public string Country { get; }
        public int Population { get; }

        public PopulationAgeStructureItem(string ageGroup, string gender, string country, int population) {
            (AgeGroup, Gender, Country, Population) = (ageGroup, gender, country, population);
        }
    }
}
