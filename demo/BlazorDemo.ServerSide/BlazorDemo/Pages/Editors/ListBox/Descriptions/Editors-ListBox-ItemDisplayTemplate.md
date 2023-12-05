The [ItemDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ItemDisplayTemplate) property allows you to customize the appearance of [List Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2) items. The property accepts a [ListBoxItemDisplayTemplateContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1) object as the **context** parameter. You can use the parameter's members to get information about items:

* [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.DataItem)
* [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.DisplayText)
* [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxItemDisplayTemplateContext-1.Value)
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxDisplayTemplateContextBase-1.VisibleIndex)


In this demo, the **ItemDisplayTemplate** property is used to display the ListBox's items in a card-like view. Each item shows an employee's first name, last name, photo, and phone number.
