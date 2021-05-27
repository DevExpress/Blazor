using System;
using System.Collections.Generic;
using System.Text;
using BlazorDemo.Configuration;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace BlazorDemo.Shared {
    public class NavMenuFactoryComponent : ComponentBase {

        [Inject]
        public DemoConfiguration Configuration { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder) {
#if SERVER_BLAZOR
            if(Configuration.ShowOnlyReporting) {
                builder.OpenComponent<NavMenuReporting>(0);
                builder.CloseComponent();
            } else {
                builder.OpenComponent<NavMenu>(1);
                builder.CloseComponent();
            }
#else
            builder.OpenComponent<NavMenu>(0);
            builder.CloseComponent();
#endif
        }
    }
}
