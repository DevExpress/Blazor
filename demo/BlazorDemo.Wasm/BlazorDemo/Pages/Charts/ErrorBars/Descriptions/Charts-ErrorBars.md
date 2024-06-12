[Error bars](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar) indicate measurement precision or uncertainty. They display a possible value range next to a series point. Error bars can display fixed values or percentages, statistical function values, or error values obtained from data source fields.

To configure error bars for a series, you must:
1. Add a [DxChartSeriesValueErrorBar](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar) object to series markup.
2. Specify [source fields](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar#obtain-error-bar-values-from-a-data-source) or [calculation method](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar#calculate-error-bars-values) for error bar values.
3. *Optional*. Specify error bar [display mode](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar.DisplayMode).
4. *Optional*. Customize error bar [appearance](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar#customize-error-bar-appearance).

In this demo, the bar series displays [fixed-value](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesValueErrorBar.Value) error bars. The line series obtains its error bar values from data source fields.
