Use the [ItemDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ItemDisplayTemplate) property to customize the appearance of TagBox items. The property accepts[TagBoxItemDisplayTemplateContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxItemDisplayTemplateContext-1) object as its **context** parameter. You can use the parameter's members to obtain item information:

* [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxItemDisplayTemplateContext-1.DataItem)
* [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.DisplayText)
* [HighlightedDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.HighlightedDisplayText)
* [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.Value)
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxDisplayTemplateContextBase-1.VisibleIndex)

In this demo, the **ItemDisplayTemplate** property is used to display TagBox items in a card-like view. The [TagDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.TagDisplayTemplate) property customizes the appearance of TagBox tags.
