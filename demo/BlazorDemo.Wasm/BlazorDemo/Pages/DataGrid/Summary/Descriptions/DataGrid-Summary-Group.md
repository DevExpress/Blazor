Group summaries (using aggregate functions such as Sum, Min, Max, Avg, and Count) are calculated across all rows within a group and displayed in the group row or group footer. To create group summaries, add [DxDataGridSummaryItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridSummaryItem) objects to the [GroupSummary](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.GroupSummary) collection.

Use the [GroupSummaryPosition](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSummaryItemBase-1.GroupSummaryPosition) property to position group summaries. The following values are available:

*   [GroupSummaryPosition.GroupRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GroupSummaryPosition) (Default) — The summary is displayed in parentheses after the group header.
*   [GroupSummaryPosition.GroupFooter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.GroupSummaryPosition) — The summary is displayed in the group footer below the target column.
