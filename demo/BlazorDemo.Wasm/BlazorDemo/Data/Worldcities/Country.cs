using System.Runtime.InteropServices;

namespace BlazorDemo.Data.Worldcities {
    [Guid("63C844CD-4619-4658-814C-49DF251FFF4A")]
    public class Country {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int CapitalId { get; set; }
    }
}

