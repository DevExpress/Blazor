The [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2) is an editor that allows users to select an item from a drop-down list. Users can click an item in the drop-down list or use the ARROW UP, ARROW DOWN, and ENTER keys to navigate between items and select them. When a user presses and holds an arrow key, the editor's window continuously navigates between items.

The main ComboBox API members are listed below:

*   [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Data) - Specifies the data source that populates the editor's list items.
*   [TextFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.TextFieldName) - Specifies the data source's field that supplies text for items.
*   [Text](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Text) - Specifies the editor's text.
*   [TextChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.TextChanged) - Fires when the editor text was changed.
*   [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Value) - Specifies the drop-down list's selected value.
*   [ValueChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.ValueChanged) - Fires when the selected value was changed.

The ComboBox component supports different size modes. To specify the component's size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxResizableEditorBase-2.SizeMode) property. To apply different size modes, use the drop-down list in the demo card's header.

This demo illustrates how to bind the ComboBox to a list of complex business objects.
