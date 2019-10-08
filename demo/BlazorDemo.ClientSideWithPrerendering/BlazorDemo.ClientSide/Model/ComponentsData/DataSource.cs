using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Blazor.Model {
    public static class ComponentsData {
        private static readonly Lazy<List<ComponentSet>> componentSets = new Lazy<List<ComponentSet>>(() => {
            return new List<ComponentSet>() {
                new ComponentSet("Components", componentSets: 
                    new List<ComponentSet>() {
                        new ComponentSet("Data Grid", GetImageUrl("GridView"), "The DevExpress Data Grid for Blazor allows you to present and manage data in a tabular format."),
                        new ComponentSet("Pivot Grid", GetImageUrl("PivotGrid"), "The DevExpress Pivot Grid for Blazor allows you to display and analyze multi-dimensional data from an underlying data source."),
                        new ComponentSet("Charts", GetImageUrl("Charts"), "DevExpress Charts for Blazor help you transform data to its most appropriate, concise and readable visual representation."),
                        new ComponentSet("Scheduler", GetImageUrl("Scheduler"), "The DevExpress Scheduler for Blazor allows you to create, display and edit scheduled appointments in a calendar format."),
                        new ComponentSet("Data Editors", GetImageUrl("Editors"), "DevExpress Data Editors for Blazor include components that can be used as standalone editors or within the Data Grid edit form."),
                        new ComponentSet("Navigation and Layout", GetImageUrl("TreeView"), "The DevExpress Navigation Suite for Blazor is a set of components designed for more effective data presentation and navigation."),
                    }
                )
            };
        });

        public static List<ComponentSet> ComponentSets { get { return componentSets.Value; } }

        static string GetImageUrl(string imageName) {
            return String.Format("./images/{0}.svg", imageName);
        }
    }
}
