Our Blazor TreeList automatically displays a vertical scrollbar if content height exceeds component size.

You can set the TreeList's [VirtualScrollingEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.VirtualScrollingEnabled) property to `true` to enable vertical virtual scrolling. In this mode, users can scroll through all rows without paging. To improve overall performance, the TreeList renders a small number of rows on-screen (based on viewport size).

To scroll the component to a specific row, pass the row's visible index to the [MakeRowVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.MakeRowVisible(System.Int32)) method.
