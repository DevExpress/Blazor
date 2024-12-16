To focus individual rows in the DevExpress Blazor TreeList, simply set the [FocusedRowEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FocusedRowEnabled) property to `true` . Note: Only one row can be focused at a time within the current page. When a page changes, the row loses focus.

Focus moves in response to the following actions:

* Users click a row with a pointing device.
* A data row switches to edit mode.
* Users navigate between rows with a keyboard. In this instance, the focused row follows the client's focus asynchronously to minimize delays.
* The TreeList loads data for the first time.
* Visible rows change (for instance, when a user sorts data or changes a page).
* The [SetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SetFocusedRowIndex(System.Int32)) method is called.

You can use the following methods to manage the focused row.

* [GetFocusedDataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.GetFocusedDataItem) — Returns a data item bound to the focused row.
* [GetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.GetFocusedRowIndex) — Returns the visible index of the focused row.
* [IsDataItemFocused](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.IsDataItemFocused(System.Object)) — Returns whether the row bound to the specified data item is focused.
* [IsRowFocused](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.IsRowFocused(System.Int32)) — Returns whether the row with the specified visible index is focused.
* [SetFocusedRowIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.SetFocusedRowIndex(System.Int32)) — Moves focus to the row with the specified visible index.

When a focused row changes, the TreeList raises its [FocusedRowChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FocusedRowChanged) event. In this demo, the [FocusedRowChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.FocusedRowChanged) event handler obtains the data item bound to the focused row and displays item information next to the TreeList.
