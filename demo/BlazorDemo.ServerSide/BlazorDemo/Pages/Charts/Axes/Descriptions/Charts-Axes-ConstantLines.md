[Constant lines](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine) are vertical and horizontal lines that pass through a chart and indicate values on corresponding axis.  

In this demo, horizontal constant lines indicate maximum and minimum levels of the Global Land-Ocean Temperature Index between the years of 1880 and 2020. A horizontal constant line is used to mark the zero level on the y-axis. 

To add a constant line to a chart, follow the steps below: 

 — Add the [DxChartConstantLine](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine) markup to the [DxChartArgumentAxis](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartArgumentAxis) or [DxChartValueAxis](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartValueAxis) component. 
 — Specify the constant line's [value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine.Value). 
 — Add a [text label](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLineLabel.Text). 

You can also define the following parameters to customize constant line appearance: 

- [Color](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine.Color) 
- [DashStyle](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine.DashStyle) 
- [DisplayBehindSeries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine.DisplayBehindSeries) 
- [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine.Width) 
- [ExtendAxis](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartConstantLine.ExtendAxis) 

Data for this demo is obtained from the following data source: [https://climate.nasa.gov/vital-signs/global-temperature/](https://climate.nasa.gov/vital-signs/global-temperature/). 
