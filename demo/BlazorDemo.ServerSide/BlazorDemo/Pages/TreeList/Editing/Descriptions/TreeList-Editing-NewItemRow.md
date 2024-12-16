Our Blazor TreeList New Item Row allows users to add new items to the root level of the TreeList component. To display this row, set the [EditNewRootItemRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditNewRootRowPosition) property to one of the following values:

* `FixedOnTop` — The TreeList displays the new item row above data records and keeps it visible during vertical scrolling and paging operations.
* `LastRow` — The TreeList displays the new item row after the last data record.

The combo box in the TreeList toolbar specifies the New Item Row's position.

You can enable [row reordering](https://docs.devexpress.com/Blazor/405244/components/treelist/drag-and-drop-rows) to allow users to move newly added items in the node hierarchy. In this demo, you can drag a row to change its position/parent.

In [EditCell](https://docs.devexpress.com/Blazor/405166/components/treelist/editing-and-validation/edit-modes/edit-cell) mode, users can press Tab or Shift+Tab keys to navigate between data cells in the new item row. When leaving the last/first cell, focus moves back to this row's first/last data cell, and the TreeList validates row values. Based on validation results, the component performs one of the following actions:

* If validation fails, the component displays error icons.
* If validation succeeds, the component saves changes and starts editing a new row.

In this demo, validation is disabled. Once focus leaves the New Item Row, the TreeList adds the row to the data source.
