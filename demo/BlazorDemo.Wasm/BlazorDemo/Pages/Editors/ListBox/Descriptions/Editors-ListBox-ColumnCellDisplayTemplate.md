The [ColumnCellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2.ColumnCellDisplayTemplate) property allows you to specify custom content and change the appearance of cells in [ListBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListBox-2) columns. The property accepts a [ListBoxColumnCellDisplayTemplateContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1) object as the **context** parameter. You can use the parameter's members to get information about columns:

* [Column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.Column)
* [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.DataItem)
* [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.DisplayText)
* [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.Value)
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxDisplayTemplateContextBase-1.VisibleIndex)

This demo customizes the appearance of different columns. 