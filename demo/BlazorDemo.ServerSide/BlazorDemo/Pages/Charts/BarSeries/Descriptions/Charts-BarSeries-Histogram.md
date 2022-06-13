This example uses the bar series to plot a [histogram](https://en.wikipedia.org/wiki/Histogram). The bar height depends on the number of points that belong to the histogram bin. You can change the histogram bin width in the Interval Width spin box on the top. The interval width is assigned to the [DxChartAxis.TickInterval](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.TickInterval) property. This example also applies the Count summary method used to calculate the number of values in histogram bins. 

The [DxChartBarSeries.BarPadding](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartBarSeriesBase-3.BarPadding) property specifies the padding between a bar and ticks, and consequently the bar width. 

The line series is used to plot the Normal Distribution function. You can compare the line and bar graphs to see how close theoretical calculations are to actual results. 

Since the magnitude of bar and line series point values is different, this chart uses a secondary value axis (hidden) to plot the line series. The [DxChart.SynchronizeAxes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.SynchronizeAxes) property is set to false to disable axis synchronization and avoid distortion of graphs. 
