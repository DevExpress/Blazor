Set the [FocusedRowEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FocusedRowEnabled) property to `true` to allow users to focus individual grid rows in the DevExpress Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid). Note: Only one row can be focused at a time and it must be a row on the selected page. If you navigate to a different page, the row loses focus.

Focus moves under the following conditions/events:

* A user clicks a row with a pointing device.
* A user navigates between rows with a keyboard (the [KeyboardNavigationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.KeyboardNavigationEnabled) property is set to `true`). In this case, the focused row follows the client's focus asynchronously to minimize delays.
* The Grid moves focus on initial load or when visible rows change (for instance, when a user sorts data or changes a page).
* The [SetFocusedDataItemAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedDataItemAsync(System.Object)) or [SetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedRowIndex(System.Int32)) method is called.

You can use the following methods to manage the focused row.

* [GetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetFocusedRowIndex) — Returns the visible index of the focused row.
* [SetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedRowIndex(System.Int32)) — Moves focus to the row with the specified visible index.
* [IsRowFocused](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.IsRowFocused(System.Int32)) — Returns whether the row with the specified visible index is focused.
* [GetFocusedDataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetFocusedDataItem) — Returns a data item bound to the focused data row.
* [SetFocusedDataItemAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SetFocusedDataItemAsync(System.Object)) — Moves focus to the row bound to the specified data item.
* [IsDataItemFocused](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.IsDataItemFocused(System.Object)) — Returns whether the row bound to the specified data item is focused.

When the focused row changes, the Grid raises its [FocusedRowChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FocusedRowChanged) event. In this demo, the [FocusedRowChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FocusedRowChanged) event handler obtains the data item bound to the focused row and displays item information next to the Grid.
