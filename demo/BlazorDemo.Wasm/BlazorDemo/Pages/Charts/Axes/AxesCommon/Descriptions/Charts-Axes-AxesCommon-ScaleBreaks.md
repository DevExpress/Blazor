A scale break allows you to cut a part of the axis to improve the readability of a chart with high amplitude values or outliers.

Use the [AutoBreaksEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartValueAxis.AutoBreaksEnabled) property to calculate scale breaks automatically. The number of calculated breaks depends on the source data. The [MaxAutoBreakCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartValueAxis.MaxAutoBreakCount) property allows you to limit the maximum number of auto-created scale breaks if the `AutoBreaksEnabled` is set to **true**.

Along with auto breaks, you can define the breaks manually. To do this, use the [DxChartScaleBreak](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartScaleBreak) component. To limit a scale break, specify the [StartValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartScaleBreak.StartValue) and [EndValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartScaleBreak.EndValue) properties. 

In this demo, you can choose the maximum number of auto-created breaks or disable them.
