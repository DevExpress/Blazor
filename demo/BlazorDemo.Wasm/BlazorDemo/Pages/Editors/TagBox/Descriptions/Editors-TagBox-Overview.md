The DevExpress Blazor [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) allows users to select multiple items (tags) from a predefined drop-down list. Users can also enter values in the edit box to filter list items matching the search string.

Key TagBox API members are listed below:

*   [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxListEditorBase-2.Data) — Specifies the data source used to populate the list items.
*   [TextFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxListEditorBase-2.TextFieldName) — Specifies the data source field that supplies item text.
*   [Tags](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.Tags) — Specifies the editor tags.
*   [TagsChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.TagsChanged) — Fires when the tag collection is changed.
*   [Values](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.Values) — Specifies the drop-down list's selected values.
*   [ValuesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ValuesChanged) — Fires when the selected value collection is changed.


The TagBox component supports different size modes. To specify component size in code, use the [SizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxEditorBase.SizeMode) property. To apply different size modes, use the drop-down list in the demo card's header.

The TagBox supports keyboard navigation ([list of supported keyboard shortcuts](https://docs.devexpress.com/Blazor/405478/components/data-editors/tagbox/keyboard-support)). Users can focus the component edit box, navigate through tags and remove them, navigate within the drop-down item list, and select items.

This demo illustrates how to bind the Blazor TagBox to a list of complex business objects.
