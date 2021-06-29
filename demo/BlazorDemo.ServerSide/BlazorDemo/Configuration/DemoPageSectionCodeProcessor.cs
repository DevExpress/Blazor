using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BlazorDemo.Configuration {
    public static class DemoPageSectionCodeProcessor {
        const RegexOptions options = RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.Compiled;
        static readonly string[] DemoContainersToExtractCode = new string[] {
            "DemoResizableContent",
            "DemoMobileContent"
        };
        static readonly Regex[] DemoContainersToExtractCodeRegex = DemoContainersToExtractCode.Select(name => new Regex(@$"<{name}[^>]*>(?<Code>.*?)<\/{name}>", options)).ToArray();
        static readonly Regex DemoPageSectionComponentRegex = new Regex(@"<DemoPageSectionComponent[^>]*>(?<Code>.*?)<\/DemoPageSectionComponent>", options);
        static readonly Regex DemoPageSectionComponentChildContentRegex = new Regex(@"\s*<ChildContent[^>]*>(?<Code>.*?)<\/ChildContent>", options);
        static readonly Regex DemoPageSectionComponentChildContentWithParametersRegex = new Regex(@"\s*<ChildContentWithParameters[^>]*>(?<Code>.*?)<\/ChildContentWithParameters>", options);
        static readonly Regex DemoPageSectionComponentOptionsContentRegex = new Regex(@"\s*<OptionsContent[^>]*>(?<Code>.*?)<\/OptionsContent>", options);
        static readonly Regex DemoPageSectionBaseClassSizeModeAttributeRegex = new Regex("\\s?@?(Item)?SizeMode=\"[^\"]*\"", options);
        static readonly Regex DemoPageSectionBaseClassThemeAttributeRegex = new Regex("\\s?@key=\"[^\"]*\"", options);
        static readonly Regex DemoDataProviderAccessAreaRegex = new Regex(@"<DataProviderAccessAreaContainer[^>]*>(?<Code>.*?)<\/DataProviderAccessAreaContainer>", options);
        static readonly Regex RandomWrapperRegex = new Regex(@"RandomWrapperFactory.Create\((?<Parameter>[^)]*?)\)", options);
        static readonly Regex IDataProviderRegex = new Regex(@"\:\s+IDataProvider", options);
        static readonly Regex GuidAttributeRegEx = new Regex("\\[Guid\\(\"[0-9A-F]{8}[-]?(?:[0-9A-F]{4}[-]?){3}[0-9A-F]{12}\"\\)\\]");
        public static readonly Regex CollapseRegex = new Regex(@"(?:@\*|\/\*)BeginCollapse(?:\*@|\*\/)(?<Code>.*?)(?:@\*|\/\*)EndCollapse(?:\*@|\*\/)", options);
        public static readonly Regex HideRegex = new Regex(@"(?:@\*|\/\*)BeginHide(?:\*@|\*\/).*?(?:@\*|\/\*)EndHide(?:\*@|\*\/)", options);
        static readonly Regex DemoPageSectionCollapsedCodeRegex = new Regex("<%--(?<CollapsedCode>.*?)--%>", options);
        static readonly string[] NewLineSignatures = new string[] { "namespace", "@code", "public class Startup" };

        public static string ProcessCode(string code) {
            code = GetDemoCode(code);
            code = ReplaceCommonParameters(code);
            code = ReplaceRandomWrapper(code);
            code = ReplaceIDataProvider(code);
            code = ReplaceGuidAttribute(code);
            code = string.Join("", SplitAndReplaceCode(code, DemoPageSectionCollapsedCodeRegex,
                                                       match => match.Groups["CollapsedCode"]?.Value ?? "",
                                                       HttpUtility.HtmlEncode));
            code = ProcessCodeLines(code, lines => RemoveWhitespaces(lines.Where(l => !string.IsNullOrWhiteSpace(l))));
            code = ProcessNewLineSignatures(code);
            return code;
        }
        static IEnumerable<string> RemoveWhitespaces(IEnumerable<string> lines) {
            var count = int.MaxValue;
            foreach(var l in lines)
                count = Math.Min(count, l.Length - l.TrimStart(' ').Length);
            return lines.Select(l => l.Substring(count));
        }
        static string GetDemoCode(string code) {
            var match = DemoPageSectionComponentRegex.Match(code);
            code = match.Success ? match.Groups["Code"].Value : code;
            foreach(var regex in DemoContainersToExtractCodeRegex) {
                code = ReplaceCode(code, regex, m => m.Success ? m.Groups["Code"].Value : "");
            }
            code = ReplaceHideRegion(code);
            code = ReplaceCollapseRegion(code);
            code = ReplaceCode(code, DemoPageSectionComponentOptionsContentRegex);
            var codeParts = SplitAndReplaceCode(code, DemoPageSectionComponentChildContentRegex,
                match => match.Groups["Code"]?.Value ?? "");
            codeParts = codeParts.SelectMany(p => SplitAndReplaceCode(p, DemoPageSectionComponentChildContentWithParametersRegex,
                match => match.Groups["Code"]?.Value ?? ""));
            codeParts = codeParts.SelectMany(p => SplitAndReplaceCode(p, DemoDataProviderAccessAreaRegex,
                match => match.Groups["Code"]?.Value ?? ""));
            return string.Join("\r\n", codeParts.Select(p => ProcessCodeLines(TrimCode(p), RemoveWhitespaces)));
        }
        static string ProcessCodeLines(string code, Func<string[], IEnumerable<string>> method) {
            string[] lines = code.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("\r\n", method(lines));
        }
        static string ProcessNewLineSignatures(string code) {
            foreach(var s in NewLineSignatures) {
                code = code.Replace(s, "\r\n" + s);
            }
            return code;
        }

        static IEnumerable<string> SplitAndReplaceCode(string code, Regex regex, MatchEvaluator eval = null, Func<string, string> notMatch = null) {
            notMatch = notMatch ?? (s => s);
            var matches = regex.Matches(code);
            var pos = 0;
            foreach(Match match in matches) {
                yield return notMatch(code.Substring(pos, match.Index - pos));
                if(eval != null)
                    yield return eval(match);
                pos = match.Index + match.Length;
            }
            yield return notMatch(code.Substring(pos));
        }
        static string ReplaceRandomWrapper(string code) {
            return ReplaceCode(code, RandomWrapperRegex, match => "new Randow(" + (match.Groups["Parameter"] != null ? match.Groups["Parameter"].Value : "") + ")");
        }
        static string ReplaceIDataProvider(string code) {
            return ReplaceCode(code, IDataProviderRegex);
        }
        static string ReplaceGuidAttribute(string code) {
            return ReplaceCode(code, GuidAttributeRegEx);
        }
        static string ReplaceCode(string code, Regex regex, MatchEvaluator eval = null)
            => string.Join("", SplitAndReplaceCode(code, regex, eval));
        static string ReplaceCommonParameters(string code) {
            code = ReplaceCode(code, DemoPageSectionBaseClassSizeModeAttributeRegex);
            code = ReplaceCode(code, DemoPageSectionBaseClassThemeAttributeRegex);
            return code;
        }
        static string ReplaceHideRegion(string code) {
            return ReplaceHideRegion(HideRegex, code);
        }
        static string ReplaceCollapseRegion(string code) {
            return ReplaceCollapseRegion(CollapseRegex, code);
        }
        static string ReplaceHideRegion(Regex regex, string code) {
            return regex.Replace(code, "");
        }
        static string ReplaceCollapseRegion(Regex regex, string code) {
            return regex.Replace(code, match => {
                return GetCollapseRegionHtml(match.Groups["Code"].Value);
            });
        }
        static string GetCollapseRegionHtml(string code) {
            string startComment = "<%--";
            string endComment = "--%>";
            return string.Format("{1}<span class=\"more-code\"><button type=\"button\" class=\"btn btn-secondary\" onclick=\"DemoPageSectionHelper.expandCode(this)\"></button>" +
                   "<span style=\"display:none\">{2}{0}{1}</span></span>{2}", code.Trim(' ', '\t', '\r', '\n'), startComment, endComment);
        }
        static string TrimCode(string code) {
            string[] lines = code.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < lines.Length; i++)
                lines[i] = lines[i].TrimEnd(' ', '\t');
            return string.Join("\r\n", lines).Trim('\r', '\n');
        }
    }
}
