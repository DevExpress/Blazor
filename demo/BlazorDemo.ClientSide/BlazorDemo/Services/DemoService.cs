using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo.Services {
    public class ThemeAttributes
    {
        private readonly DemoService DemoService;

        public string Name { get; }
        public string IconCssClass { get; }
        public bool IsLoaded { get; set; }
        public bool InLoading { get; set; }
        public bool IsActive => DemoService.CurrentTheme == Name;

        public string ResourceUrl => $"_content/BlazorDemo/css/switcher-resources/themes/{Name}/bootstrap.min.css";
        public string CssClass => IsActive ? "active" : "text-muted";
        public string RenderKey => $"key_{IsActive.ToString()}_{Name}_{IsLoaded.ToString()}_{InLoading.ToString()}";
        public ThemeAttributes(DemoService DemoService, string name)
        {
            this.DemoService = DemoService;
            Name = name;
            IconCssClass = name.ToLower().Replace(" ", "-");
        }

    }

    public class ThemeSetModel
    {
        public string Title { get; }
        public ThemeAttributes[] Themes { get; }
        public ThemeSetModel(DemoService DemoService, string title, params string[] themes) {
            Title = title;
            Themes = themes.Select(CreateThemeAttributes).ToArray();
            
            
            ThemeAttributes CreateThemeAttributes(string name) {
                return new ThemeAttributes(DemoService, name);
            }
        }
    }
    
    public class DemoService {
        public DemoService() {
            ResourcesReadyState = new ConcurrentDictionary<string, TaskCompletionSource<bool>>();
            ThemeSets = CreateSets(this);
        }

        public ConcurrentDictionary<string, TaskCompletionSource<bool>> ResourcesReadyState { get; } 
        public string CurrentTheme { get; set; } = "blazing berry";
        public List<ThemeSetModel> ThemeSets { get; }

        private static List<ThemeSetModel> CreateSets(DemoService DemoService)
        {
            return new List<ThemeSetModel>() {
                new ThemeSetModel(DemoService, "Color Themes",  "default"),
                new ThemeSetModel(DemoService, "DevExpress Themes", "blazing berry", "purple", "office white"),
                new ThemeSetModel(DemoService, "Bootswatch Themes", "cerulean", "cosmo", "cyborg", "darkly", "flatly", "journal", "litera", "lumen", "lux", "materia", "minty", "pulse",
                    "sandstone", "simplex", "sketchy", "slate", "solar", "spacelab", "superhero", "united", "yeti")
            };
        }
    }
}