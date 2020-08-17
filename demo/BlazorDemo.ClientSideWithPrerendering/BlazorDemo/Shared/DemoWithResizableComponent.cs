using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Blazor;
using Microsoft.AspNetCore.Components;

namespace BlazorDemo.Shared {
    public abstract class DemoWithResizableComponent : ComponentBase {

        protected SizeMode SizeMode { get; set; }


        protected override void OnInitialized() {
            base.OnInitialized();
            SizeMode = SizeMode.Small;
        }

    }
}
