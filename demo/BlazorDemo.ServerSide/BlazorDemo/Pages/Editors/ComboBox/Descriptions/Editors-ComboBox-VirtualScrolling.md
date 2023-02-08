Use the [ListRenderMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.ListRenderMode) property to specify how the [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2#virtual-scrolling) renders the item list.

*   [Entire](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListRenderMode) - The ComboBox renders the entire item list. Use this option for small item lists where scrolling should work instantly.
*   [Virtual](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListRenderMode) - The ComboBox renders items only after they appear in the viewport. Use this option to improve performance when the list contains too many items to render simultaneously.

In this demo, the [ListRenderMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.ListRenderMode) property is set to [ListRenderMode.Virtual](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListRenderMode).
