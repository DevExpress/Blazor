Group summaries are calculated across all rows within a group and displayed in the group row or group footer. To create group summaries, declare [DxGridSummaryItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem) objects in the [GroupSummary](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupSummary) template.  

You can use the following DxGridSummaryItem properties: 

* [SummaryType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.SummaryType) — Specifies the function type (Sum, Min, Max, Avg, or Count). 
* [FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.FieldName) — Specifies the name of the data field whose values are used to calculate the summary. The Min and Max functions support data fields whose values can be compared. The Avg and Sum functions work with numeric fields only. For the Count function, you do not need to set this property. 
* [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.DisplayText)  — Specifies display text pattern for the summary item. A display text string can include static text and placeholders for summary value and column caption.
* [ValueDisplayFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.ValueDisplayFormat) — Specifies the pattern used to format the summary value. If you do not define this property, the summary applies the format from the column bound to the same data field ([FieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.FieldName). For more information about supported formats, see the following help topic: [Format types in .NET](https://docs.microsoft.com/en-us/dotnet/standard/base-types/formatting-types). 
* [FooterColumnName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.FooterColumnName) — Specifies the name of the group footer column that displays the summary value. If you do not define this property, the summary value is displayed in the group row. 
* [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.Visible) — Allows you to show/hide individual summary items.

In this demo, group rows display the number of rows and total prices within groups. 
