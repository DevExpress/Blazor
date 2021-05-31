using System;
using System.Linq;

namespace BlazorDemo.Configuration {
    public class DemoSearchResult : IComparable<DemoSearchResult> {
        public DemoSearchResult(DemoPageBase page, DemoPageSection section, int rank) {
            Page = page;
            Section = section;
            Rank = rank;
        }

        public DemoPageSection Section { get; private set; }
        public DemoPageBase Page { get; private set; }

        public string Text { get; set; }
        public int Rank { get; set; }

        int IComparable<DemoSearchResult>.CompareTo(DemoSearchResult other) {
            return other.Rank.CompareTo(Rank);
        }
    }
}
