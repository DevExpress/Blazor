To display data in our Blazor [Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid), [bind](https://docs.devexpress.com/Blazor/403737/grid/bind-to-data) it to a data collection and declare column objects in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template. Use the [FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FieldName) property to bind a column to a field from the Grid's data collection. The Grid generates a user-friendly column caption based on the field name. Use the [Caption](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.Caption) property to specify a custom column name.

You can define columns in the Grid's markup, but cannot change the column collection at runtime. The Grid supports the following predefined data column types.

##### Bound columns

- Text column - Use the [DxDataGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn) type to display strings and use a text box to edit values. Refer to the [Data Binding](Grid/DataBinding) demo to see this column type in action.
- Date-time column - Bind a [DxDataGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn) to a DateTime field and define the [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowCellTemplate) (if required). You can also apply a custom format to date-time values. To do this, specify the [DisplayFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.DisplayFormat) property. Refer to the [Filter Row](Grid/Filtering) demo to see this solution in action.
- Checkbox column - Bind a [DxDataGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn) to a Boolean field and use the column’s [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.CellDisplayTemplate) property to define a column display template. Refer to the [Filter Row](Grid/Filtering) demo to see this column type in action.
- Combobox column - Bind a [DxDataGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn) to a field that stores column data. Handle the [CustomizeCellDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomizeCellDisplayText) event as demonstrated in the [Grid - Overview](Grid) module and define the [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowCellTemplate) (if required).

##### Unbound columns

[Unbound columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn#create-an-unbound-column) display values that are not stored in the assigned data collection. To create an unbound column, declare a [DxGridDataColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn) object in the Columns template and specify the column’s [UnboundType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundType) property. Then, specify the [UnboundExpression](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.UnboundExpression) property or handle the [UnboundColumnData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.UnboundColumnData) event to calculate column values. 

To define how the column should display calculated values, use the solutions listed above. Refer to the [Summary](Grid/Summary) demo to see this column type in action.

##### Command column

Use the [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object to define a command column in markup. This column contains data management buttons that allow users to create, edit, and remove rows. Refer to the [Edit Data](Grid/EditData) demo to see this column type in action.

##### Selection column

Use the [DxGridSelectionColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSelectionColumn) object to define a selection column in markup. This column allows users to select and deselect rows. It contains checkboxes or radio buttons depending on [selection mode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.SelectionMode). Refer to the [Selection Column](Grid/Selection#SelectionColumn) demo to see this solution in action.
