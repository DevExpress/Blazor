Our Blazor [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) can display data across multiple columns. To create columns, use [DxListEditorColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn) objects as needs dictate. Objects include the following column customization options:

*   [Caption](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.Caption) — Specifies the column caption.
*   [FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.FieldName) — Specifies the data source field used to populates column items.
*   [SearchEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.SearchEnabled) — Specifies whether the component can search text in cells associated with the current column.
*   [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.Visible) — Specifies the column visibility.
*   [VisibleChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.VisibleChanged) — Fires when the column visibility changes.
*   [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.VisibleIndex) — Specifies the column display order.
*   [VisibleIndexChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.VisibleIndexChanged) — Fires when the column's visible index changes.
*   [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.Width) — Specifies the column width.

To format an editor value, use the [EditFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.EditFormat) property. This property allows you to format values displayed in both standard and multi-column ComboBoxes. A `{0} {1}` format specifies that the editor value includes values for the following columns: **FirstName** (`VisibleIndex = 0`) and **LastName** (`VisibleIndex = 1`).
