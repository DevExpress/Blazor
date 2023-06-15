The DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid) allows users to focus individual grid rows. Note: Only one row can be focused within the current page. If you navigate to a different page, the Grid will lose row focus.

Set the [FocusedRowEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FocusedRowEnabled) property to `true` to enable the focused row option in the Grid. 

Focus moves under the following conditions/events:

* A user clicks a row with a pointing device
* The Grid moves focus on initial load or when visible rows change (for instance, when a user sorts data or changes a page)
* The [SetFocusedDataItemAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedDataItemAsync(System.Object)) or [SetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedRowIndex(System.Int32)) method is called

When focused row changes, the Grid raises its [FocusedRowChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FocusedRowChanged) event.

You can use the following methods to manage the focused row.

* [GetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetFocusedRowIndex) — Returns the visible index of the focused row.
* [SetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedRowIndex(System.Int32)) — Moves focus to the row with the specified visible index.
* [IsRowFocused](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.IsRowFocused(System.Int32)) — Returns whether the row with the specified visible index is focused.
* [GetFocusedDataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetFocusedDataItem) — Returns a data item bound to the focused data row.
* [SetFocusedDataItemAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedDataItemAsync(System.Object)) — Moves focus to the row bound to the specified data item.
* [IsDataItemFocused](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.IsDataItemFocused(System.Object)) — Returns whether the row bound to the specified data item is focused.

In this demo, the [FocusedRowChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FocusedRowChanged) event is handled to get the data item bound to the focused row and display item information below/next to the Grid.
