using System;
using System.Collections.Generic;

namespace BlazorDemo.Data {
    public class ComponentSet {
        Lazy<List<ComponentSet>> componentSets = new Lazy<List<ComponentSet>>();

        public ComponentSet(string title, string imageUrl = "", string description = "", List<ComponentSet> componentSets = null) {
            Title = title;
            ImageUrl = imageUrl;
            Description = description;
            if(componentSets != null)
                ComponentSets.AddRange(componentSets);
        }

        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<ComponentSet> ComponentSets { get { return componentSets.Value; } }
    }
}
