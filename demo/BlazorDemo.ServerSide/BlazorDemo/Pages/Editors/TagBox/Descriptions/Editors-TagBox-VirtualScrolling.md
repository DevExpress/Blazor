Use the [ListRenderMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ListRenderMode) property to specify how the [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) loads the item list.

*   [Entire](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListRenderMode) - The TagBox loads the entire item list. Use this option for small item lists where scrolling should work instantly.
*   [Virtual](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListRenderMode) - The TagBox loads visible items only. Use this option to improve performance when the list contains to many items to load simultaneously.

In this demo, the [ListRenderMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ListRenderMode) property is set to [ListRenderMode.Virtual](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListRenderMode).
