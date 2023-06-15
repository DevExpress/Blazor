using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.DemoData {
    public class DemoSearchHelper {
        public DemoSearchHelper(DemoSearchModel searchModel, IEnumerable<DemoRootPage> rootPages) {
            RootPages = rootPages;
            SearchAgregator = new DemoSearchAgregator(searchModel);
        }

        public IEnumerable<DemoRootPage> RootPages { get; private set; }
        public DemoSearchAgregator SearchAgregator { get; private set; }

        protected Dictionary<DemoItem, Dictionary<string, int>> KeywordsRankList { get; private set; } = new Dictionary<DemoItem, Dictionary<string, int>>();

        public List<DemoSearchResult> DoSearch(string request) {
            var results = new List<DemoSearchResult>();
            if(!string.IsNullOrEmpty(request)) {
                var requests = SearchAgregator.SplitRequests(request);
                try {
                    foreach(var rootPage in RootPages) {
                        if(rootPage.IsMaintenanceMode) continue;

                        results.AddRange(DoSearch(requests, rootPage));
                    }
                }
                catch {
                }
                results = results.OrderByDescending(sr => sr.Rank).ToList();
            }
            return results;
        }
        IEnumerable<DemoSearchResult> DoSearch(List<string[]> requests, DemoPageBase page) {
            var results = new List<DemoSearchResult>();
            foreach(var childPage in page.Pages) {
                if(childPage.IsMaintenanceMode) continue;

                if(childPage.Pages.Length > 0)
                    results.AddRange(DoSearch(requests, childPage));
                else {
                    int resultCount = results.Count;
                    foreach(var section in childPage.PageSections)
                        results.AddRange(GetRes(requests, section, DemoSearchAgregator.HighlightOccurences(section.Title, requests)));
                    if(results.Count == resultCount)
                        results.AddRange(GetRes(requests, childPage, DemoSearchAgregator.HighlightOccurences(childPage.Title, requests)));
                }
            }
            results.AddRange(GetRes(requests, page, DemoSearchAgregator.HighlightOccurences(page.Title, requests)));
            return results;
        }
        IEnumerable<DemoSearchResult> GetRes(List<string[]> requests, DemoItem item, string text) {
            var results = new List<DemoSearchResult>();
            var rank = CalculateRank(requests, item);
            if(rank > -1) {
                var sr = new DemoSearchResult(item, rank);
                sr.Text = text;
                results.Add(sr);
            }
            return results;
        }
        int CalculateRank(List<string[]> requests, DemoItem item) {
            int resultRank = 0;
            int keywordRank = 0;
            foreach(var request in requests) {
                int requestRank = -1;
                if(item is DemoPageSection && item.ParentPage.GetChildItems().Length > 1 && DemoSearchAgregator.CalculateRank(request, GetKeywordsRankList(item), out keywordRank))
                    requestRank += keywordRank;
                if(item is DemoPageBase && DemoSearchAgregator.CalculateRank(request, GetKeywordsRankList(item), out keywordRank))
                    requestRank += keywordRank;
                if(item is DemoRootPage && DemoSearchAgregator.CalculateRank(request, GetKeywordsRankList(item), out keywordRank))
                    requestRank += keywordRank;
                if(requestRank == -1 && SearchAgregator.WordsExclusions.Any(re => re.Equals(request[0], DemoSearchAgregator.DefaultStringComparison)))
                    requestRank = 0;

                if(requestRank > -1)
                    resultRank += requestRank;
                else
                    return -1;
            }
            return resultRank;
        }
        Dictionary<string, int> GetKeywordsRankList(DemoItem item) {
            if(!KeywordsRankList.ContainsKey(item)) {
                List<TextRank> textRanks = new List<TextRank>();

                var rootPage = item as DemoRootPage;
                var page = item as DemoPage;

                if(rootPage != null) {
                    textRanks.Add(new TextRank(rootPage.Title, 15));
                    textRanks.Add(new TextRank(rootPage.Id, 7));
                    textRanks.Add(new TextRank(rootPage.SearchKeywords, 7));
                    textRanks.Add(new TextRank(rootPage.SeoTitle, 5));
                    textRanks.Add(new TextRank(rootPage.Keywords, 3));
                } else if(page != null) {
                    textRanks.Add(new TextRank(page.Title, 5));
                    textRanks.Add(new TextRank(page.TitleOnPage, 5));
                    textRanks.Add(new TextRank(page.SearchKeywords, 5));
                    textRanks.Add(new TextRank(page.Id, 3));
                    textRanks.Add(new TextRank(page.Keywords, 3));
                    textRanks.Add(new TextRank(page.SeoTitle, 2));
                } else {
                    textRanks.Add(new TextRank(item.Title, 5));
                    textRanks.Add(new TextRank(item.TitleOnPage, 5));
                    textRanks.Add(new TextRank(item.Id, 3));
                }
                KeywordsRankList.Add(item, SearchAgregator.GetKeywordsRankList(textRanks));
            }
            return KeywordsRankList[item];
        }
    }
}
