using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlazorDemo.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDemo.Shared {
    public class NavMenuFactoryComponent : ComponentBase {

        [Inject]
        public DemoConfiguration Configuration { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
            if(Configuration.ShowOnlyReporting) {
                builder.OpenComponent<NavMenu>(0);
                builder.AddAttribute(1, "Pages", Configuration.RootPages.Where(x => x.Id == "Reports").FirstOrDefault().Pages);
                builder.CloseComponent();
            } else {
                builder.OpenComponent<NavMenu>(2);
                builder.AddAttribute(3, "Pages", Configuration.RootPages);
                builder.CloseComponent();
            }
        }
    }
}
