DevExpress Blazor [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows you to reserve an area for an axis and its labels (the [PlaceholderSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.PlaceholderSize) property). When axis labels overflow this region, you can use one of the following options to define how to display such labels:

* Text Overflow — the [TextOverflow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisLabel.TextOverflow) property specifies how axis labels are truncated. `Ellipsis`, `Hide`, and `None` options are available.
* Word Wrap — the [WordWrap](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisLabel.WordWrap) property specifies how axis labels are wrapped. `BreakWord`, `Normal`, and `None` options are available.

In this demo, you can specify content area size for the argument axis and use drop-down menus to specify the display options for axis labels.
