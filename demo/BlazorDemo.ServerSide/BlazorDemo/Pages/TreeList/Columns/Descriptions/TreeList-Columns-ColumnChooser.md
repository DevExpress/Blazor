The DevExpress Blazor TreeList allows users to customize its column list via its integrated Column Chooser. User can:

* Display or hide columns: users can toggle the appropriate checkbox within the column chooser. This action modifies a column's [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListColumn.Visible) property value.
* Reorder columns: users can drag a column header to a different position within the column chooser. This action modifies a column's [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListColumn.VisibleIndex) property value.

Call the [ShowColumnChooser](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ShowColumnChooser) method to display the column chooser. You can use a column's [ShowInColumnChooser](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeListColumn.ShowInColumnChooser) property to specify whether the column appears in that window.

In this demo, the TreeList's [toolbar](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ToolbarTemplate) displays a button that invokes our built-in Column Chooser.
