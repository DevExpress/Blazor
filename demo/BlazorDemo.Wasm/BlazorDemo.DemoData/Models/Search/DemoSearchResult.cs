using System;
using System.Linq;

namespace BlazorDemo.DemoData {
    public class DemoSearchResult : IComparable<DemoSearchResult> {
        public DemoSearchResult(DemoItem item, int rank) {
            Item = item;
            Rank = rank;
        }

        public DemoItem Item { get; private set; }

        public string Text { get; set; }
        public int Rank { get; set; }

        int IComparable<DemoSearchResult>.CompareTo(DemoSearchResult other) {
            return other.Rank.CompareTo(Rank);
        }
    }
}
