using BlazorDemo.Services;
using DevExpress.Blazor;

namespace BlazorDemo.Configuration {
    public class DemoTheme {
        public ITheme Theme { get; set; }
        public string Name { get; }
        public string Title { get; }
        public string IconCssClass => Name.ToLower();
        public string MenuBackgroundColor { get; }
        public bool IsFluent { get; init; }
        public bool IsBootstrapNative { get; init; }
        public string BootstrapThemeMode { get; init; } = "light";
        public ThemeFluentAccentColor? FluentAccentColor { get; }
        public static string GetCssClass(bool isActive) => isActive ? "active" : null;

        public DemoTheme(string name, string title) {
            Name = name;
            Title = title;
        }

        public DemoTheme(ITheme theme, string name, string title, string menuBackgroundColor) : this(name, title) {
            Theme = theme;
            MenuBackgroundColor = menuBackgroundColor;
        }
        public DemoTheme(string name, string title, string menuBackgroundColor, ThemeFluentAccentColor color) : this(null, name, title, menuBackgroundColor) {
            FluentAccentColor = color;
            IsFluent = true;
        }

        public ITheme ApplyStoredState(ThemeState themeState) {
            if(!IsFluent)
                return Theme;

            return Themes.Fluent.Clone(properties => {
                properties.Mode = themeState.Mode ?? ThemeMode.Light;
                properties.UseBootstrapStyles = true;

                if(FluentAccentColor != null)
                    properties.AccentColor = FluentAccentColor.Value;

                if(themeState.CustomAccentColor != null)
                    properties.SetCustomAccentColor(themeState.CustomAccentColor);

                properties.Name = $"{Name}{properties.Mode}{themeState.CustomAccentColor}";

                properties.AddFilePaths(BlazorDemoThemes.FluentCommonStylesPath);

                if(properties.Mode == ThemeMode.Light)
                    properties.AddFilePaths(BlazorDemoThemes.HighlightJsDefaultTheme);

                if(properties.Mode == ThemeMode.Dark)
                    properties.AddFilePaths(BlazorDemoThemes.HighlightJsAndroidTheme);
            });
        }
    }
}
