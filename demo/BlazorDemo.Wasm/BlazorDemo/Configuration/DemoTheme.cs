using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BlazorDemo.Configuration {
    public class DemoTheme {
        public string Name { get; }
        public string Title { get { return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(Name.Replace("-", " ")); } }
        public string IconCssClass { get { return Name.ToLower(); } }
        public bool IsBootstrapNative { get; }
        public string GetCssClass(bool isActive) => isActive ? "active" : "text-body";
        public DemoTheme(string name, bool isBootstrapNative) {
            Name = name;
            IsBootstrapNative = isBootstrapNative;
        }
    }

    public class DemoThemeSet {
        static readonly HashSet<string> BuiltInThemes = new HashSet<string>() {
            "blazing-berry", "blazing-dark", "purple", "office-white"
        };
        public string Title { get; }
        public DemoTheme[] Themes { get; }
        public DemoThemeSet(string title, params string[] themes) {
            Title = title;
            Themes = themes.Select(CreateTheme).ToArray();


            DemoTheme CreateTheme(string name) {
                bool isBootstrapNative = !BuiltInThemes.Contains(name);
                return new DemoTheme(name, isBootstrapNative);
            }
        }
    }
}
