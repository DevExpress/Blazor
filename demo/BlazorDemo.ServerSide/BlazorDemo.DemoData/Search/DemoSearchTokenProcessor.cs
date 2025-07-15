using System.Text.RegularExpressions;

namespace BlazorDemo.DemoData {
    public class DemoSearchTokenProcessor {
        internal const StringComparison STRING_COMPARISON = StringComparison.OrdinalIgnoreCase;
        const int DISTANCE_THRESHOLD = 3;
        const double DISTANCE_LENGTH_NORMALIZED_THRESHOLD = 0.24;

        public DemoSearchTokenProcessor(DemoSearchModel searchModel) {
            SearchModel = searchModel;
        }

        protected DemoSearchModel SearchModel { get; }

        HashSet<string> _tokenExclusions;
        protected HashSet<string> Exclusions {
            get {
                if(_tokenExclusions == null)
                    _tokenExclusions = SplitTextByTokens(SearchModel.Exclusions?.Words, true).ToHashSet() ?? new();
                return _tokenExclusions;
            }
        }

        string[] _prefixExclusions;
        protected string[] PrefixesExclusions {
            get {
                if(_prefixExclusions == null)
                    _prefixExclusions = SplitTextByTokens(SearchModel.Exclusions?.Prefixes, true);
                return _prefixExclusions;
            }
        }

        string[] _postfixExclusions;
        protected string[] PostfixesExclusions {
            get {
                if(_postfixExclusions == null)
                    _postfixExclusions = SplitTextByTokens(SearchModel.Exclusions?.Postfixes, true);
                return _postfixExclusions;
            }
        }

        Dictionary<string, string[]> _synonyms;
        protected IReadOnlyDictionary<string, string[]> Synonyms {
            get {
                if(_synonyms == null) {
                    _synonyms = new();
                    foreach(var groupItem in SearchModel.Synonyms?.Groups ?? []) {
                        var tokens = SplitTextByTokens(groupItem, true);
                        foreach(var item in tokens)
                            _synonyms[item] = tokens;
                    }
                }
                return _synonyms;
            }
        }

        public bool IsExclusion(string token) {
            return Exclusions.Contains(token);
        }
        public TokenRank CalculateRank(string[] synonyms, Dictionary<string, TokenRank> keywordsRankList) {
            TokenRank rank = null;
            foreach(var synonym in synonyms) {
                rank = FindRankInKeywordsRankList(keywordsRankList, synonym);
                if(rank != null) return rank;
            }
            return null;
        }
        TokenRank FindRankInKeywordsRankList(Dictionary<string, TokenRank> keywordsRankList, string str) {
            if(keywordsRankList.TryGetValue(str, out var rank)) return rank;
            var keyword = keywordsRankList.Keys.FirstOrDefault(k => MatchToken(str, k));
            return keyword != null ? keywordsRankList[keyword] : null;
        }

        public string[][] SplitRequestBySynonymTokens(string request) {
            var requestTokens = SplitTextByTokens(request, true);
            var result = new List<string[]>();
            foreach(var requestToken in requestTokens) {
                var resultWord = PrepareToken(requestToken);
                if(!Synonyms.TryGetValue(resultWord, out var synonymGroup))
                    synonymGroup = Synonyms.FirstOrDefault(kv => MatchToken(resultWord, kv.Key), new(resultWord, [resultWord])).Value;
                result.Add(synonymGroup);
            }
            return result.ToArray();
        }
        string PrepareToken(string token) {
            foreach(var prefix in PrefixesExclusions) {
                if(token.StartsWith(prefix, STRING_COMPARISON) && token.Length > prefix.Length)
                    token = token.Remove(0, prefix.Length);
            }
            foreach(var postfix in PostfixesExclusions) {
                if(token.EndsWith(postfix, STRING_COMPARISON) && token.Length > postfix.Length)
                    token = token.Substring(0, token.Length - postfix.Length);
            }
            return token;
        }
        static bool MatchToken(string requestToken, string indexToken) {
            if(indexToken.StartsWith(requestToken, STRING_COMPARISON))
                return true;
            var distance = requestToken.Length >= indexToken.Length ?
                DamerauLevenshteinDistance(indexToken, requestToken) :
                DamerauLevenshteinDistance(requestToken, indexToken);
            return (double)distance / (double)Math.Max(requestToken.Length, indexToken.Length) <= DISTANCE_LENGTH_NORMALIZED_THRESHOLD;
        }

        static int DamerauLevenshteinDistance(string source, string target) {
            int length1 = source.Length;
            int length2 = target.Length;
            if(Math.Abs(length1 - length2) > DISTANCE_THRESHOLD) { return int.MaxValue; }

            int maxi = length1;
            int maxj = length2;

            int[] dCurrent = new int[maxi + 1];
            int[] dMinus1 = new int[maxi + 1];
            int[] dMinus2 = new int[maxi + 1];
            int[] dSwap;

            for(int i = 0; i <= maxi; i++) { dCurrent[i] = i; }

            int jm1 = 0, im1 = 0, im2 = -1;

            for(int j = 1; j <= maxj; j++) {
                dSwap = dMinus2;
                dMinus2 = dMinus1;
                dMinus1 = dCurrent;
                dCurrent = dSwap;
                int minDistance = int.MaxValue;
                dCurrent[0] = j;
                im1 = 0;
                im2 = -1;

                for(int i = 1; i <= maxi; i++) {
                    int cost = source[im1] == target[jm1] ? 0 : 1;
                    int del = dCurrent[im1] + 1;
                    int ins = dMinus1[i] + 1;
                    int sub = dMinus1[im1] + cost;
                    int min = (del > ins) ? (ins > sub ? sub : ins) : (del > sub ? sub : del);
                    if(i > 1 && j > 1 && source[im2] == target[jm1] && source[im1] == target[j - 2])
                        min = Math.Min(min, dMinus2[im2] + cost);
                    dCurrent[i] = min;
                    if(min < minDistance) { minDistance = min; }
                    im1++;
                    im2++;
                }
                jm1++;
                if(minDistance > DISTANCE_THRESHOLD) { return int.MaxValue; }
            }

            int result = dCurrent[maxi];
            return (result > DISTANCE_THRESHOLD) ? int.MaxValue : result;
        }

        static Regex TokenSplitRegex = new(@"(?<!^)(?=[A-Z][a-z](?![A-Z]|$))|(?<!^)(?=[A-Z])(?<=[a-z])|[\s\,\/\\\-\+]+", RegexOptions.Compiled);//, " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();

        public string[] SplitTextByTokens(string text, bool ignoreException) {
            if(string.IsNullOrWhiteSpace(text)) return [];
            return new HashSet<string>(TokenSplitRegex
                .Split(text)
                .Concat(text.Split())
                .Where(s => !string.IsNullOrWhiteSpace(s) && (ignoreException || (s.Length > 1 && !IsExclusion(s))))
                .Select(s => s.ToLower())
            ).ToArray();
        }

        public Dictionary<string, TokenRank> GetTokenRankDict(TokenRank[] tokenRanks) {
            var result = new Dictionary<string, TokenRank>();
            foreach(var textRank in tokenRanks) {
                if(textRank.Text == null) continue;
                var words = SplitTextByTokens(textRank.Text, false);
                foreach(var word in words) {
                    var rankWord = PrepareToken(word);
                    if(!result.TryGetValue(rankWord, out var rank) || rank.Rank < textRank.Rank)
                        result[rankWord] = textRank;
                }
            }
            return result;
        }
    }

    public record TokenRank {
        public TokenRank(string text, int rank, TextRankSource sources) {
            Text = text;
            Rank = rank;
            Sources = sources;
        }
        public string Text { get; }
        public int Rank { get; }
        public TextRankSource Sources { get; }
    }

    [Flags]
    public enum TextRankSource {
        None = 0,
        Section = 1,
        Keywords = 2,
        Url = 4,
        Header = 8,
        ParentTitle = 16,
        Title = 32
    }
}
