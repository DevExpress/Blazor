using ItemRankCache = System.Collections.Generic.Dictionary<BlazorDemo.DemoData.DemoItemBase, System.Collections.Generic.Dictionary<string[], BlazorDemo.DemoData.TokenRank>>;

namespace BlazorDemo.DemoData {
    public class DemoSearchEngine {
        const double ITEM_FACTOR_ADDITION_TO_PARENT_MATCH = 0.5;

        public DemoSearchEngine(DemoSearchModel searchModel, IEnumerable<DemoGroup> groupModel) {
            Groups = groupModel;
            TokenProcessor = new DemoSearchTokenProcessor(searchModel);
        }

        protected IEnumerable<DemoGroup> Groups { get; }
        protected DemoSearchTokenProcessor TokenProcessor { get; }
        protected Dictionary<DemoItemBase, Dictionary<string, TokenRank>> KeywordsRankList { get; } = new();

        public DemoSearchResult DoSearch(string request) {
            if(string.IsNullOrEmpty(request)) return DemoSearchResult.Empty();
            var requests = TokenProcessor.SplitRequestBySynonymTokens(request);
            var result = new DemoSearchResult(request, requests);
            foreach(var group in Groups)
                DoSearch(result, requests, group);
            return result;
        }

        protected void DoSearch(DemoSearchResult result, string[][] requests, DemoGroup group) {
            foreach(var childPage in group.Pages) {
                ItemRankCache rankCache = new();
                DoSearch(result, requests, childPage, rankCache);
            }
        }

        protected void DoSearch(DemoSearchResult result, string[][] requests, DemoPage page, ItemRankCache rankCache) {
            if(page.IsMaintenanceMode) return;

            if(!string.IsNullOrEmpty(page.GetUrl())) {
                var pageRank = CalculateRank(requests, page, rankCache);
                if(page?.PageSections?.Length > 0) {
                    var sectionRanks = page.PageSections.Select(s => CalculateRank(requests, s, rankCache)).ToArray();
                    var foundSectionWithHigherRank = false;
                    for(var i = 0; i < sectionRanks.Length; i++) {
                        if(sectionRanks[i] != null && (pageRank == null || sectionRanks[i].Rank > pageRank.Rank)) {
                            result.RegisterItem(page.PageSections[i], sectionRanks[i].Rank, sectionRanks[i].Sources);
                            foundSectionWithHigherRank = true;
                        }
                    }
                    if(foundSectionWithHigherRank)
                        pageRank = null;
                }
                if(pageRank != null)
                    result.RegisterItem(page, pageRank.Rank, pageRank.Sources);
            }

            if(page.Pages != null) {
                foreach(var childPage in page.Pages)
                    DoSearch(result, requests, childPage, rankCache);
            }
        }

        TokenRank CalculateRank(string[][] requests, DemoItem item, ItemRankCache rankCache) {
            int itemRankValue = 0;
            TextRankSource itemRankSources = TextRankSource.None;
            foreach(var tokens in requests.Where(r => !TokenProcessor.IsExclusion(r[0]))) {
                var tokenRank = CalculateRank(tokens, item, rankCache);
                if(tokenRank != null) {
                    itemRankValue += tokenRank.Rank;
                    itemRankSources = itemRankSources | tokenRank.Sources;
                } else
                    return null;
            }
            return new TokenRank(string.Empty, itemRankValue, itemRankSources);
        }
        TokenRank CalculateRank(string[] request, DemoItemBase item, ItemRankCache rankCache) {
            return GetOrCalculateRank(item, request, rankCache, () => {
                var rankList = GetTokenRankIndex(item);
                var itemRank = TokenProcessor.CalculateRank(request, rankList);

                if(item is DemoItem demoItem) {
                    var parentRank = CalculateRank(request, (DemoItemBase)demoItem.ParentPage ?? demoItem.RootPage.Group, rankCache);
                    if(parentRank != null && (itemRank == null || itemRank.Rank < parentRank.Rank)) {
                        var rankValue = (int)Math.Round(parentRank.Rank + (itemRank?.Rank ?? 0) * ITEM_FACTOR_ADDITION_TO_PARENT_MATCH);
                        itemRank = new TokenRank(itemRank?.Text ?? parentRank.Text, rankValue, CalculateTextRankSource(parentRank, itemRank));
                    }
                }
                return itemRank;
            });
        }

        TokenRank GetOrCalculateRank(DemoItemBase item, string[] tokens, ItemRankCache rankCache, Func<TokenRank> calcFunc) {
            if(rankCache.TryGetValue(item, out var itemRankCache)) {
                if(itemRankCache.TryGetValue(tokens, out var rank))
                    return rank;
                return itemRankCache[tokens] = calcFunc();
            }
            var result = calcFunc();
            rankCache[item] = new() {
                [tokens] = result
            };
            return result;
        }


        TextRankSource CalculateTextRankSource(TokenRank parentRank, TokenRank itemRank) {
            if(itemRank == null || parentRank.Sources > itemRank.Sources)
                return parentRank.Sources == TextRankSource.Title ? TextRankSource.ParentTitle : parentRank.Sources;
            return itemRank.Sources;
        }

        Dictionary<string, TokenRank> GetTokenRankIndex(DemoItemBase item) {
            if(KeywordsRankList.TryGetValue(item, out var res)) return res;
            switch(item) {
                case DemoPage page:
                    if(page.ParentPage == null) {
                        KeywordsRankList.Add(item, TokenProcessor.GetTokenRankDict([
                            new(page.Title, 20, TextRankSource.Title),
                            new(page.SearchKeywords, 10, TextRankSource.Keywords),
                            new(page.Id, 7, TextRankSource.Url),
                            new(page.SeoTitle, 5, TextRankSource.Keywords),
                            new(page.Keywords, 3, TextRankSource.Keywords)
                        ]));
                    } else {
                        KeywordsRankList.Add(item, TokenProcessor.GetTokenRankDict([
                            new(page.Title, 15, TextRankSource.Title),
                            new(page.SearchKeywords, 10, TextRankSource.Keywords),
                            new(page.TitleOnPage, 10, TextRankSource.Header),
                            new(page.Id, 3, TextRankSource.Url),
                            new(page.Keywords, 3, TextRankSource.Keywords),
                            new(page.SeoTitle, 2, TextRankSource.Keywords)
                        ]));
                    }
                    break;
                case DemoPageSection section:
                    KeywordsRankList.Add(item, TokenProcessor.GetTokenRankDict([
                        new(section.Title, 15, TextRankSource.Title),
                        new(section.TitleOnPage, 10, TextRankSource.Header),
                        new(section.Id, 3, TextRankSource.Url)
                    ]));
                    break;
                default:
                    KeywordsRankList.Add(item, TokenProcessor.GetTokenRankDict([
                        new(item.Title, 5, TextRankSource.Title)
                    ]));
                    break;
            }
            return KeywordsRankList[item];
        }
    }
}
