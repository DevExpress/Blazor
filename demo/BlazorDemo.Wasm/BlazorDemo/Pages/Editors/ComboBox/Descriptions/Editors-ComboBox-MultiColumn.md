The [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) can display data across multiple columns. To create columns, use [DxListEditorColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn) objects that include the following options for column customization:

*   [Caption](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.Caption) - Specifies the column caption.
*   [FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.FieldName) - Specifies the data source field that populates column items.
*   [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataColumnBase.Visible) - Specifies the column visibility.
*   [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataColumnBase.VisibleIndex) - Specifies the column display order.
*   [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataColumnBase.Width) - Specifies the column width.

To format an editor value, use the [EditFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.EditFormat) property. This property allows you to format values displayed in both ordinary and multi-column ComboBoxes. The `{1} {2}` format specifies that the editor value includes values of the following columns: **Name** (`VisibleIndex = 1`) and **Surname** (`VisibleIndex = 2`).
