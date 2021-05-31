using System.Collections.Generic;

namespace BlazorDemo.Data {
    public static class ComponentSets {
        private static readonly List<ComponentSet> componentSets =  new List<ComponentSet>() {
                new ComponentSet("Components", componentSets:
                    new List<ComponentSet>() {
                        new ComponentSet("Data Grid", GetImageUrl("grid"),
                            "The DevExpress Data Grid for Blazor allows you to present and manage data in a tabular format."),
                        new ComponentSet("Pivot Grid", GetImageUrl("pivot"),
                            "The DevExpress Pivot Grid for Blazor allows you to display and analyze multi-dimensional data from an underlying data source."),
                        new ComponentSet("Charts", GetImageUrl("chart"),
                            "DevExpress Charts for Blazor help you transform data to its most appropriate, concise and readable visual representation."),
                        new ComponentSet("Scheduler", GetImageUrl("scheduler"),
                            "The DevExpress Scheduler for Blazor allows you to create, display and edit scheduled appointments in a calendar format."),
                        new ComponentSet("Data Editors", GetImageUrl("editors"),
                            "DevExpress Data Editors for Blazor include components that can be used as standalone editors or within the Data Grid edit form."),
                    }
                )
            };

        public static List<ComponentSet> Data { get { return componentSets; } }

        static string GetImageUrl(string imageName) {
            return StaticAssetUtils.GetImagePath($"components/{imageName}.svg");
        }
    }
}
