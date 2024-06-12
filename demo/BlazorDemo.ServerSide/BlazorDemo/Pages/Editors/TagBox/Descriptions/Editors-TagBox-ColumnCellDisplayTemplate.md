The [ColumnCellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2.ColumnCellDisplayTemplate) property allows you to specify custom content and change the appearance of cells associated with [TagBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTagBox-2) columns. The property accepts [TagBoxColumnCellDisplayTemplateContext](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxColumnCellDisplayTemplateContext-1) object as its **context** parameter. You can use parameter members to obtain column information:

* [Column](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.Column)
* [DataItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.TagBoxColumnCellDisplayTemplateContext-1.DataItem)
* [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.DisplayText)
* [HighlightedDisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.HighlightedDisplayText)
* [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxColumnCellDisplayTemplateContext-1.Value)
* [VisibleIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ListBoxDisplayTemplateContextBase-1.VisibleIndex)

This demo customizes the appearance of different columns. 