using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Worldcities {
    [Guid("8125D9B2-19FA-441A-9690-32005E9ED83C")]
    public class City {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
    }
}
