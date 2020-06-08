using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;
using DevExpress.Blazor;

namespace BlazorDemo.Shared {
    public abstract class DemoWithResizableComponent : ComponentBase {
        
        protected SizeMode SizeMode { get; set; }


        protected override void OnInitialized() {
            base.OnInitialized();
            SizeMode = SizeMode.Small;
        }

    }
}
