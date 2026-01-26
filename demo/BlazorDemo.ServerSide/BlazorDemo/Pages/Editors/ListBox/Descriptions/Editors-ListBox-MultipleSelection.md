To enable multi selection in the [List Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2), set the [SelectionMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.SelectionMode) property to [ListBoxSelectionMode.Multiple](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.SelectionMode).

Users can select multiple items as follows:

* Press **Ctrl** to select individual items or hold **Shift** to select a range of items.
*   If the [ShowCheckboxes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ShowCheckboxes) property is `true`, users can click individual items or corresponding checkboxes.
*   If [ShowSelectAllCheckbox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ShowSelectAllCheckbox) and [ShowCheckboxes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ShowCheckboxes) properties are `true`, users can click the **Select All** checkbox to select all visible items in the list.

You can use [SelectAllAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.SelectAllAsync) and [DeselectAllAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.DeselectAllAsync) methods to select/deselect all visible items in code.
