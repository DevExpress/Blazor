The [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) allows you to select data that matches the specified criterion from a data source and display chart series based on this data.

To do this, use the following settings available through the [DxChartCommonSeries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4) object:

*   [NameField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.NameField) - A data field that specifies series names.
*   [SummaryMethod](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.SummaryMethod) - A method that calculates summaries for points with the same argument value. You can use any function with the Func<IEnumerable<TValue>, TValue> signature as a value of this setting. A static **Enumerable.Sum** method is used in this demo.
*   [ArgumentField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.ArgumentField) - A data field that specifies series arguments.
*   [ValueField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.ValueField) - Specifies a data field that specifies series values.

You can also use the [SeriesTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.SeriesTemplate) property to specify different templates for specific series types: [DxChartBarSeries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartBarSeries-3), [DxChartLineSeries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartLineSeries-3), and other type-specific series objects. Note that the [SeriesTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.SeriesTemplate) property is used as many times as the number of data groups that match the specified criterion.

The following chart displays two series with multiple points. The point labels can overlap each other. The [LabelOverlap](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.LabelOverlap) property is set to [ChartLabelOverlap.Hide](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartLabelOverlap) to hide overlapping labels. You can also set this property to [ChartLabelOverlap.Stack](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartLabelOverlap) to arrange labels in a stack formation.
