Use our Blazor [Grid](https://docs.devexpress.com/Blazor/403143/grid)'s built-in selection column to simplify row selection. To display this column, declare a [DxGridSelectionColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSelectionColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template.

**Multi Select Mode (default)**

In multi select mode, the column contains check boxes. The  **Select All** check box within the column's header selects/deselects all rows on the current page or all Grid pages. Use the [SelectAllCheckboxMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectAllCheckboxMode) property to specify check box behavior. Available property values are as follows:

* `Page` — The check box affects all rows on the current Grid page.
* `AllPages` — The check box affects all rows on all Grid pages.
* `Mixed` — The check box affects all rows on the current Grid page. An additional drop-down button displays a context menu and allows users to select/deselect all rows on all Grid pages.

To hide the **Select All** check box, disable the column's [AllowSelectAll](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSelectionColumn.AllowSelectAll) option.

**Single Select Mode**

When set to `Single`, the [SelectionMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectionMode) property allows users to select a single row.

In this demo, the selection column contains check boxes so that users can select multiple rows. Use the combo box above the Grid to select the desired **Select All** check box mode.
