The [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component automatically detects the first series' data type and uses it to render X (argument) and Y (value) axes. If the data range or format is series specific, each series can use its own Y axis. The number of Chart's Y axes is not limited.

To change the type of an axis, use its [Type](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.Type) property. The following axis types are available:

*   [Auto](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartAxisType) (Default) — For integer and float data types, displays numeric arguments/values divided by ticks (the **Continuous** type). For other data types, displays discrete arguments/values that correspond to chart points (the **Discrete** type).
*   [Continuous](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartAxisType) — Displays numeric arguments/values divided by ticks.
*   [Discrete](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartAxisType) — Displays discrete arguments/values that correspond to chart points.
*   [Logarithmic](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartAxisType) — Displays numeric arguments/values that grow exponentially. Each axis argument/value equals to the [LogarithmBase](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.LogarithmBase) value raised to some power. For example, if **LogarithmBase** is set to 10, the following arguments/values are displayed: 10<sup>-2</sup>, 10<sup>-1</sup>, 10<sup>0</sup>, 10<sup>1</sup>, 10<sup>2</sup>, etc. This type is useful when you need to visualize a dataset of rapidly-growing values.

In this demo, two Chart components display argument axes of the **Discrete** type, and value axes of **Continuous** and **Logarithmic** types, respectively. The **LogarithmBase** property for the second chart is set to 2.
