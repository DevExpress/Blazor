Use the [ItemDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.ItemDisplayTemplate) property to customize the appearance of [ComboBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2#items) items. This property accepts a [ComboBoxItemDisplayTemplateContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ComboBoxItemDisplayTemplateContext-1) object as its **context** parameter. You can use the parameter's members to obtain item information.

* [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ComboBoxItemDisplayTemplateContext-1.DataItem)
* [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.DisplayText)
* [HighlightedDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.HighlightedDisplayText)
* [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.Value)
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxDisplayTemplateContextBase-1.VisibleIndex)

In this demo, the **ItemDisplayTemplate** property is used to display the ComboBox's items in a card-like view. Each item displays an employee's first name, last name, photo, and phone number.
