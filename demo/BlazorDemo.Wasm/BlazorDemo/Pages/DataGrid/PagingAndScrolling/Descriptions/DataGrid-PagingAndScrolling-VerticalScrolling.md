This demo module illustrates how to enable vertical scrolling in the DevExpress [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1) for Blazor.

The Data Grid's height is determined by the number of rows displayed within a page. Use the [DxDataGrid.VerticalScrollBarMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.VerticalScrollBarMode) property to display the vertical scrollbar and reduce the Data Grid's height. Use the [DxDataGrid.VerticalScrollableHeight](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.VerticalScrollableHeight) property to specify the height of the scrollable area (in pixels).

The [DxDataGrid.VerticalScrollBarMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.VerticalScrollBarMode) property accepts the following values:

*   [Auto](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ScrollBarMode) - The scrollbar is automatically shown when the size of the component content exceeds the size of the component itself.
*   [Hidden](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ScrollBarMode) - The scrollbar is hidden.
*   [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ScrollBarMode) - The scrollbar is visible.
