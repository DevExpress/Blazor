DevExpress Blazor [Chart](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows you to display and configure [axis strips](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisStrip). Use a strip to highlight a range between two axis values or an area above/below a value. Such highlighted areas allow users to quickly see whether a point falls in or out of a predefined range.

To create an axis strip, you must:

1. Add a [DxChartAxisStrip](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisStrip) object to axis markup ([DxChartArgumentAxis](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartArgumentAxis) or [DxChartValueAxis](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartValueAxis)).

2. Use [StartValue](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisStrip.StartValue) and [EndValue](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisStrip.EndValue) properties to specify the range. Use both properties to highlight an area between two values. Define only one property to highlight the area above or below a certain value.

3. Specify the [Color](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisStrip.Color) property to display the strip.

4. *Optional*. Add a [DxChartAxisStripLabel](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisStripLabel) object to strip markup to configure strip label settings.

This demo displays two value axis strips: "Above average high" and "Below average low". The [DxChartFont](http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartFont) component customizes font settings used for strip labels.
