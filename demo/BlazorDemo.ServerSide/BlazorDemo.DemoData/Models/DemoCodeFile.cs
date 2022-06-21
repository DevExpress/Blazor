using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BlazorDemo.DemoData {
    public class DemoCodeFile {
        public string Title { get; set; }
        public string Path { get; set; }
        public string ExtractRegex { get; set; }
        public string[] ExtractRegexGroups { get; set; }

        public string GetPreparedContent(string content) {
            if(!string.IsNullOrWhiteSpace(ExtractRegex) && !string.IsNullOrWhiteSpace(content)) {
                var matches = new Regex(ExtractRegex)
                                    .Matches(content)
                                    .Where(m => m.Success)
                                    .ToArray();
                if(matches.Length > 0) {
                    content = string.Join("\n", matches.Select(m => {
                        if(ExtractRegexGroups?.Length > 0) {
                            var groupValues = "";
                            foreach(var group in ExtractRegexGroups) {
                                if(m.Groups[group].Success)
                                    groupValues += m.Groups[group].Value;
                            }

                            if(!string.IsNullOrEmpty(groupValues))
                                return groupValues;
                        }

                        return m.Value;
                    }));
                } else
                    Console.Error.WriteLine($"No match in reqex {ExtractRegex} in file {Path}");
            }
            return content;
        }
    }
}

