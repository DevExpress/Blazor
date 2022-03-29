using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DevExpress.Blazor.DocumentMetadata;
using Newtonsoft.Json;

namespace BlazorDemo.Configuration {
    public class DemoSearchHelper {
        public DemoSearchHelper(DemoSearchModel searchModel, IEnumerable<DemoRootPage> rootPages) {
            RootPages = rootPages;
            SearchAgregator = new DemoSearchAgregator(searchModel);
        }

        public IEnumerable<DemoRootPage> RootPages { get; private set; }
        public DemoSearchAgregator SearchAgregator { get; private set; }

        protected Dictionary<DemoPageSection, Dictionary<string, int>> KeywordsRankList { get; private set; } = new Dictionary<DemoPageSection, Dictionary<string, int>>();

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
        IEnumerable<DemoSearchResult> DoSearch(List<string[]> requests, DemoRootPage rootPage) {
            var results = new List<DemoSearchResult>();
            foreach(var page in rootPage.Pages) {
                if(page.IsMaintenanceMode) continue;

                int resultCount = results.Count;
                foreach(var section in page.GetPageSections)
                    results.AddRange(GetRes(requests, page, section, DemoSearchAgregator.HighlightOccurences(section.Title, requests)));
                if(results.Count == resultCount)
                    results.AddRange(GetRes(requests, page, null, DemoSearchAgregator.HighlightOccurences(page.Title, requests)));
            }
            results.AddRange(GetRes(requests, rootPage, null, DemoSearchAgregator.HighlightOccurences(rootPage.Title, requests)));
            return results;
        }
        IEnumerable<DemoSearchResult> GetRes(List<string[]> requests, DemoPageBase page, DemoPageSection section, string text) {
            var results = new List<DemoSearchResult>();
            var rank = CalculateRank(requests, page, section);
            if(rank > -1) {
                var sr = new DemoSearchResult(page, section, rank);
                sr.Text = text;
                results.Add(sr);
            }
            return results;
        }
        int CalculateRank(List<string[]> requests, DemoPageBase page, DemoPageSection section) {
            int resultRank = 0;
            int keywordRank = 0;
            foreach(var request in requests) {
                int requestRank = -1;
                if(section != null && page is DemoPage && ((DemoPage)page).GetPageSections.Length > 1 && DemoSearchAgregator.CalculateRank(request, GetKeywordsRankList(section), out keywordRank))
                    requestRank += keywordRank;
                if(page != null && DemoSearchAgregator.CalculateRank(request, GetKeywordsRankList(page), out keywordRank))
                    requestRank += keywordRank;
                if(page is DemoRootPage && DemoSearchAgregator.CalculateRank(request, GetKeywordsRankList(page), out keywordRank))
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
        Dictionary<string, int> GetKeywordsRankList(DemoPageSection model) {
            if(!KeywordsRankList.ContainsKey(model)) {
                List<TextRank> textRanks = new List<TextRank>();

                var rootPage = model as DemoRootPage;
                var page = model as DemoPage;

                if(rootPage != null) {
                    textRanks.Add(new TextRank(rootPage.Title, 15));
                    textRanks.Add(new TextRank(rootPage.Id, 7));
                    textRanks.Add(new TextRank(rootPage.SeoTitle, 5));
                    textRanks.Add(new TextRank(rootPage.Keywords, 3));
                } else if(page != null) {
                    textRanks.Add(new TextRank(page.Title, 5));
                    textRanks.Add(new TextRank(page.Id, 3));
                    textRanks.Add(new TextRank(page.Keywords, 3));
                    textRanks.Add(new TextRank(page.SeoTitle, 2));
                } else {
                    textRanks.Add(new TextRank(model.Title, 5));
                    textRanks.Add(new TextRank(model.Id, 3));
                }
                KeywordsRankList.Add(model, SearchAgregator.GetKeywordsRankList(textRanks));
            }
            return KeywordsRankList[model];
        }
    }
}
