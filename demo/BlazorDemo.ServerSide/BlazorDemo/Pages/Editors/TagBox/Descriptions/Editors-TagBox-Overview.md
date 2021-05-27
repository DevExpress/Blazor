The [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) is an editor that allows users to select multiple items (tags) from a predefined drop-down list. Users can also type in the edit box to filter list items that contain the search string. Users can also use the ARROW UP, ARROW DOWN, and ENTER keys to navigate to the editor's items and select them. When a user presses and holds an arrow key, the editor's window continuously navigates between items. To remove a tag, users can click its remove button or press Backspace.

The main TagBox API members are listed below:

*   [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.Data) - Specifies the data source that populates the editor’s list items.
*   [TextFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.TextFieldName) - Specifies the data source’s field that supplies text for items.
*   [Tags](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.Tags) - Specifies the editor’s tags.
*   [TagsChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.TagsChanged) - Fires when the tag collection is changed.
*   [Values](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.Values) - Specifies the drop-down list’s selected values.
*   [ValuesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ValuesChanged) - Fires when the selected value collection is changed.

The TagBox component supports different size modes. To specify the component's size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxResizableEditorBase-2.SizeMode) property. To apply different size modes, use the drop-down list in the demo card's header.

This demo illustrates how to bind the TagBox to a list of complex business objects.
