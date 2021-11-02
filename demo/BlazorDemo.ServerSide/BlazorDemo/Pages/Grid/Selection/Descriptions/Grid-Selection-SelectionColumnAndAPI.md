Use our Blazor Data Grid’s built-in selection column to simplify row selection. To display this column, declare a [DxGridSelectionColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSelectionColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template.

* In multiple selection mode (like this demo), the column contains checkboxes. The checkbox in the column’s header selects/deselects all rows on the current page.
* In single selection mode, the column contains radio buttons.

Use the following API to manage row selection in code:
* [SelectRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectRow(System.Int32-System.Boolean)), [SelectRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectRows(System.Collections.Generic.IEnumerable-System.Int32--System.Boolean)) – Select a single row or multiple rows.
* [SelectDataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectDataItem(System.Object-System.Boolean)), [SelectDataItems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectDataItems(System.Collections.Generic.IEnumerable-System.Object--System.Boolean)) – Select a single data item or multiple data items (that correspond to rows).
* [SelectAllOnPage](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectAllOnPage(System.Boolean)) – Selects all rows on the current page.
* [DeselectRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DeselectRow(System.Int32)), [DeselectRows](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DeselectRows(System.Collections.Generic.IEnumerable-System.Int32-)) – Deselect a single row or multiple rows.
* [DeselectDataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DeselectDataItem(System.Object)), [DeselectDataItems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DeselectDataItems(System.Collections.Generic.IEnumerable-System.Object-)) – Deselect a single data item or multiple data items (that correspond to rows).
* [DeselectAllOnPage](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DeselectAllOnPage) – Deselects all rows on the current page.
* [ClearSelection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ClearSelection) – Clears selection options.
* [IsRowSelected](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.IsRowSelected(System.Int32)), [IsDataItemSelected](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.IsDataItemSelected(System.Object)) – Return whether the specified row or data item is selected.

You can click buttons at the top of the demo card to select and deselect rows in the selected category and clear the selection.
