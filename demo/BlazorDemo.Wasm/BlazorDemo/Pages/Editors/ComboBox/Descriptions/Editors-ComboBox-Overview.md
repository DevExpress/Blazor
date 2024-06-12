The DevExpress Blazor [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) allows users to select an item from a drop-down list.

Core ComboBox API members are as follows:

*   [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.Data) — Specifies the data source used to populates the editor's list items.
*   [TextFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownListEditorBase-2.TextFieldName) — Specifies the data source's field used to supply item text.
*   [Text](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Text) — Specifies the editor's text.
*   [TextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.TextChanged) — Fires when the editor text was changed.
*   [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Value) — Specifies the drop-down list's selected value.
*   [ValueChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.ValueChanged) — Fires when the selected value was changed.

Our Blazor ComboBox component supports different size modes. To specify the component's size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxResizableEditorBase-2.SizeMode) property. To apply different size modes, use the drop-down list in the demo card's header.

ComboBox also supports keyboard navigation ([list of supported keyboard shortcuts](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2#keyboard-navigation)), allowing users to navigate within the item list and select an item.

In this demo, the DevExpress ComboBox is bound to a list of complex business objects.
