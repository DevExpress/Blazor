Our Blazor TreeList **New Item Row** allows users to add new items to the root level of the TreeList component. Use the [EditNewRootRowPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditNewRootRowPosition) property to specify visibility and location of the new root nodes:

* `Top` — The New Item Row is hidden. Once a user clicks the **New** button or you call the [StartEditNewRowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.StartEditNewRowAsync(System.String)) method, the TreeList displays an edit form, edit row, or cell editors *at the top of the current page*.
* `Bottom` — The New Item Row is hidden. Once a user clicks the **New** button or you call the [StartEditNewRowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.StartEditNewRowAsync(System.String)) method, the TreeList displays an edit form, edit row, or cell editors *at the bottom of the current page*.
* `FixedOnTop` — The TreeList displays the New Item Row above data records and keeps it visible during vertical scrolling and paging operations.
* `LastRow` — The TreeList displays the New Item Row after the last data record.

The combo box in the TreeList's toolbar specifies the New Item Row's position.

You can enable [row reordering](https://docs.devexpress.com/Blazor/405244/components/treelist/drag-and-drop-rows) to allow users to move newly added items in the node hierarchy. In this demo, you can drag a row to change its position/parent.

In [EditCell](https://docs.devexpress.com/Blazor/405166/components/treelist/editing-and-validation/edit-modes/edit-cell) mode, users can press Tab or Shift+Tab keys to navigate between data cells in the New Item Row. When leaving the last/first cell, focus moves back to this row's first/last data cell, and the TreeList validates row values. Based on validation results, the component executes one of the following actions:

* If validation fails, the component displays error icons.
* If validation passes, the component saves changes and starts editing a new row.

In this demo, validation is disabled. Once focus leaves the New Item Row, our Blazor TreeList adds the row to the data source. The [EditOnKeyPress](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditOnKeyPress) property is enabled and row editing starts once you begin typing.
