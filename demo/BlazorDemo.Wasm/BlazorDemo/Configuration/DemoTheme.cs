using System.Linq;

namespace BlazorDemo.Configuration {
    public class DemoTheme {
        private readonly DemoThemesConfiguration config;

        public string Name { get; }
        public string Title { get { return Name.Replace("-", " "); } }
        public string IconCssClass { get { return Name.ToLower(); } }
        public bool IsLoaded { get; set; }
        public bool InLoading { get; set; }

        public string GetCssClass(bool isActive) => isActive ? "active" : "text-muted";
        public string GetRenderKey(bool isActive) => $"key_{isActive.ToString()}_{Name}_{IsLoaded.ToString()}_{InLoading.ToString()}";
        public DemoTheme(DemoThemesConfiguration config, string name) {
            this.config = config;
            Name = name;
        }

    }

    public class DemoThemeSet {
        public string Title { get; }
        public DemoTheme[] Themes { get; }
        public DemoThemeSet(DemoThemesConfiguration config, string title, params string[] themes) {
            Title = title;
            Themes = themes.Select(CreateTheme).ToArray();


            DemoTheme CreateTheme(string name) {
                return new DemoTheme(config, name);
            }
        }
    }
}
