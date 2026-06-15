Bar series visualize data as rectangular bars. Follow the steps below to create a bar series:
1. Use the [DxChart.Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.Data) property to specify a data source.
2. Add a [DxChartBarSeries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartBarSeries-3) object to chart markup.
3. Use series [ArgumentField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.ArgumentField) and [ValueField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.ValueField) properties to specify data source fields that supply arguments and values (bars).
4. *Optional*. Specify series [Filter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.Filter) and [SummaryMethod](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.SummaryMethod) properties to filter and aggregate series values. This demo filters data by age group. It also groups arguments by country and calculates aggregate values using the `Enumerable.Sum` method.

The [DxChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows you to add multiple series objects to component markup. Each series can specify data used via the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.Data) property.
