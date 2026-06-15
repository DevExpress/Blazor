Spline area series display data as colored regions between the argument axis and smooth curves. Follow the steps below to create a spline area series:
1. Use the [DxChart.Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.Data) property to specify a data source.
2. Add a [DxChartSplineAreaSeries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSplineAreaSeries-3) object to chart markup.
3. Use series [ArgumentField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.ArgumentField) and [ValueField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.ValueField) properties to specify data source fields that supply arguments and values (chart points).
4. *Optional*. Specify series [Filter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.Filter) and [SummaryMethod](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.SummaryMethod) properties to filter and aggregate series values. This demo filters data by region. It also groups arguments by date and calculates aggregate values using the `Enumerable.Sum` method.

The [DxChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows you to add multiple series objects to the component markup. Each series can specify data used via the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.Data) property.

Area-based series support point [markers](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeriesPoint) and [labels](https://docs.devexpress.com/Blazor/405083/components/charts/labels#series-labels). Use checkboxes to display/hide these elements.
