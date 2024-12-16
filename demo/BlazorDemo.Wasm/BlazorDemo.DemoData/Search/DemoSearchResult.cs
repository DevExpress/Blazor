using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace BlazorDemo.DemoData {
    public class DemoSearchResult {
        static Regex ValidForHighlightingRequest = new Regex("[0-9a-zA-Z]{2,}", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        ReadOnlyCollection<DemoSearchResultItem> items;
        public DemoSearchResult(string requestString, string[][] requests) {
            RequestString = requestString;
            Requests = requests;
        }

        public int Count { get { return InnerItems.Count; } }
        public ReadOnlyCollection<DemoSearchResultItem> Items {
            get {
                if(items != null) return items;
                return items = new ReadOnlyCollection<DemoSearchResultItem>(InnerItems.Values
                    .Where(sr => sr.Rank > 0)
                    .OrderByDescending(sr => sr.Rank)
                    .ToList());
            }
        }

        protected Dictionary<string, string> HightlightCache { get; } = new();
        public string RequestString { get; }
        protected string[][] Requests { get; }
        protected Dictionary<DemoItemBase, DemoSearchResultItem> InnerItems { get; } = new();
        internal void RegisterItem(DemoItem item, int rank, TextRankSource sources) {
            if(rank < 0) throw new ArgumentException($"{nameof(rank)} cannot be less than 0");
            InnerItems.Add(item, new DemoSearchResultItem(item, rank, sources));
            var leafToParentSource = item is DemoPageSection ? TextRankSource.Section : TextRankSource.None;
            InnerItems[item.Group] = new DemoSearchResultItem(item.Group, 0, leafToParentSource);
            while((item = item.ParentPage) != null) {
                if(!InnerItems.TryGetValue(item, out var parentSource) || parentSource.Source < leafToParentSource)
                    InnerItems[item] = new DemoSearchResultItem(item, 0, leafToParentSource);
            }
            items = null;
        }
        public bool ContainsInHierarchy(DemoItemBase item) {
            return GetRankSource(item) != null;
        }
        public TextRankSource? GetRankSource(DemoItemBase item) {
            if(InnerItems.TryGetValue(item, out var result)) return result.Source;
            return null;
        }

        public static string HighlightOccurences(string text, string[][] requests) {
            var requestReplace = string.Join("|", requests.Select(r => r[0]).Where(r => ValidForHighlightingRequest.IsMatch(r)));
            Regex re = new Regex($"([a-zA-Z0-9]*({requestReplace})[a-zA-Z0-9]*)", RegexOptions.IgnoreCase);
            return re.Replace(text.Replace(" ", "&nbsp;"), "<span class=\"dxbl-filter-content\">$0</span>");
        }

        Regex highlightingRegex;
        protected Regex HighlightingRegex {
            get {
                if(highlightingRegex == null) {
                    var requestReplace = string.Join("|", Requests.Select(r => r[0]).Where(r => ValidForHighlightingRequest.IsMatch(r)));
                    highlightingRegex = new Regex($"([a-zA-Z0-9]*({requestReplace})[a-zA-Z0-9]*)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
                }
                return highlightingRegex;
            }
        }

        public string GetHighlightedMarkup(string text) {
            if(HightlightCache.TryGetValue(text, out var result)) return result;
            var markup = HighlightingRegex.Replace(text.Replace(" ", "&nbsp;"), "<span class=\"dxbl-filter-content\">$0</span>");
            HightlightCache[text] = markup;
            return markup;
        }

        public static DemoSearchResult Empty() {
            return new DemoSearchResult(string.Empty, Array.Empty<string[]>());
        }
    }

    public struct DemoSearchResultItem : IComparable<DemoSearchResultItem> {
        public DemoSearchResultItem(DemoItemBase item, int rank, TextRankSource source) {
            Item = item;
            Rank = rank;
            Source = source;
        }
        public DemoItemBase Item { get; }
        public int Rank { get; }
        public TextRankSource Source { get; }

        int IComparable<DemoSearchResultItem>.CompareTo(DemoSearchResultItem other) {
            return other.Rank.CompareTo(Rank);
        }
    }
}
