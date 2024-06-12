This demo uses the [TagDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.TagDisplayTemplate) property to customize tag's appearance.

The template's **Context** parameter has the following properties:

*   [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxTagDisplayTemplateContext-1.DataItem) — The tag's bound data item (if the tag is not custom).
*   [IsCustom]( https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxTagDisplayTemplateContext-1.IsCustom) -Returns whether the current tag is custom (not stored in the assigned data source).
*   [RemoveTagAction](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxTagDisplayTemplateContext-1.RemoveTagAction) — The predefined action that removes the tag.
*   [DisplayText]( https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxTagDisplayTemplateContext-1.DisplayText) — The tag's text.
