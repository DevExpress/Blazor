This demo shows how to use the DevExpress Chart and PieChart for Blazor to create a sales dashboard. You can select sectors that correspond to countries in the donut at the top, and then view detailed information on sales over the year in the chart at the bottom. 

To enable the ability to select multiple sectors in a pie, set the [DxPieChart.PointSelectionMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPieChart-1.PointSelectionMode) property to Multiple. 

Handle the [DxPieChart.SelectionChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPieChart-1.SelectionChanged) event to track changes in selected items. Once you select a pie sector, it is added to a collection of selected items. This example uses this collection to [filter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartXYSeries-4.Filter) series in the bottom chart to select only series that correspond to sectors selected in the pie.
