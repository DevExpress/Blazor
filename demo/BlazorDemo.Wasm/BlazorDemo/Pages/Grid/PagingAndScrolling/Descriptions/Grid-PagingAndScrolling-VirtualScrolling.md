To enable vertical virtual scrolling, set our Blazor Grid's [VirtualScrollingEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.VirtualScrollingEnabled) property to `true` . In this mode, users can scroll through all data rows without paging. To improve overall performance, the Grid renders a small number of rows on-screen (based on viewport size). For server-side data, our Grid component requests data in small chunks (when the user scrolls the component).

To make a row visible, can call the following methods:

* [MakeRowVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.MakeRowVisible(System.Int32)) — Navigates to the row with the specified visible index.
* [MakeDataItemVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.MakeDataItemVisibleAsync(System.Object)) — Navigates to the row bound to the specified data item.

In this demo, the [TextWrapEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.TextWrapEnabled) property is disabled and every row in the Grid has the same height. When text does not fit into a cell as a single line, the Grid trims extra words and displays an ellipsis. You can hover over the cell to display all the text in a tooltip.

Check the **Enable Text Wrap** check box above the Grid component to enable the word wrap option. Once enabled, a cell will display multiple lines of text when its value does not fit into the cell as a single line.
