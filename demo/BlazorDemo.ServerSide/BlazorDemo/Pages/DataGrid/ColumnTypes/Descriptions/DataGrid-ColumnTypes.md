To display data in our Blazor [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1), [bind](BindGridtoData) it to a data collection and add columns. You can define columns in the Data Grid's markup, but cannot change the column collection at runtime. In this demo, the Data Grid contains the following predefined data column types:

*   [DxDataGridDateEditColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridDateEditColumn) (Date) - Displays date-time values and uses a drop-down calendar to edit these values.
*   [DxDataGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn) (Forecast) - Displays strings and uses a text box to edit values.
*   [DxDataGridSpinEditColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridSpinEditColumn) (Temp. (℃)) - Displays numeric values and uses a spin editor to edit these values.
*   [DxDataGridComboBoxColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridComboBoxColumn-1) (Cloud Cover) - Displays any values and uses a combobox editor to edit values.
*   [DxDataGridCheckBoxColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCheckBoxColumn) (Precipitation) - Displays disabled checkboxes and allows a user to change their states in the Edit Form.

Refer to the following documentation topic for more information on available column types: [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.Columns).

Use the [Field](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.Field) property to bind a column to a field from the Data Grid's data collection. The Data Grid generates a user-friendly column caption based on the field name. Use the [Caption](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.Caption) property to specify a custom column name.

Declare a [DxDataGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridCommandColumn) object to add a command column. This column contains data management buttons that allow users to create, edit, and remove rows. Click the **Edit** button in any row to see the integrated data editors displayed by the columns listed above.

YouTube Video: [Column Customization](https://www.youtube.com/watch?v=FadGrIOBrrs&feature=youtu.be)
