This demo illustrates linked [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) and [Pivot Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPivotGrid-1) components. The chart is automatically updated when a user expands or collapses rows/columns in the Pivot Grid, and the Chart shows data from the Pivot Grid's lowest expanded level.

To link these components, do the following:

1.  Create a custom method that asynchronously returns an **IEnumerable<T>** collection (_Sales.Load()_ in this demo).
2.  Create a data provider object (_PivotGridDataProvider_ in this demo).
3.  Bind the Pivot Grid to the data provider object's [PivotGridDataSource](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPivotGridDataProvider-1.PivotGridDataSource) property.
4.  Bind Charts to the data provider object's [ChartDataSource](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPivotGridDataProvider-1.ChartDataSource) property.
5.  Assign corresponding fields to [NameField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.NameField), [ArgumentField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.ArgumentField), and [ValueField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.ValueField) properties.
6.  Additionally, you can assign a data field name to the [PaneField](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCommonSeries-4.PaneField) property. This enables the Chart to group data by the corresponding field's values and create a separate Pane for each group.
