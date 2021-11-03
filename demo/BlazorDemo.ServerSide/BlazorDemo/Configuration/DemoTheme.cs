using System.Linq;

namespace BlazorDemo.Configuration {
    public class DemoTheme {

        public string Name { get; }
        public string Title { get { return Name.Replace("-", " "); } }
        public string IconCssClass { get { return Name.ToLower(); } }

        public string GetCssClass(bool isActive) => isActive ? "active" : "text-body";
        public DemoTheme(string name) {
            Name = name;
        }

    }

    public class DemoThemeSet {
        public string Title { get; }
        public DemoTheme[] Themes { get; }
        public DemoThemeSet(string title, params string[] themes) {
            Title = title;
            Themes = themes.Select(CreateTheme).ToArray();


            DemoTheme CreateTheme(string name) {
                return new DemoTheme(name);
            }
        }
    }
}
