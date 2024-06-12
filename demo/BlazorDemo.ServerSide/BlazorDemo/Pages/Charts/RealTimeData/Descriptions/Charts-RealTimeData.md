The DevExpress [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component for Blazor supports real-time data updates. If data changes, the component only re-renders affected data points and retains its visual state (zoom and scroll position). You can use the [VisualRangeUpdateMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.VisualRangeUpdateMode) property to change the update mode of the visual range.

If the Chart contains a large number of points, you can aggregate data to optimize performance. To enable this functionality, complete the following steps:

1. Add a [DxChartAggregationSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAggregationSettings) object to chart markup.
2. Set the [DxChartAggregationSettings.Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAggregationSettings.Enabled) property to `true`.
3. Specify an aggregation method in the [DxChartAggregationSettings.Method](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAggregationSettings.Method) property. 
