The DevExpress Blazor [Range Selector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelector) allows you to visualize data on a linear scale. Users can change selection by dragging edge sliders or by moving the entire selected range. 

The component ships with APIs designed to customize the following elements and presentation options:

* Major and minor scale ticks. 
* Scale labels.
* Slider handles and markers. 
* Background and shutter. 
* Color palettes and individual element appearance.

The Range Selector can visualize data using multiple chart series [types](https://docs.devexpress.com/Blazor/405041/components/charts/series-types). To display a chart series, you must:

1. Use the [DxRangeSelector.Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelector.Data) property to bind the Range Selector to a data source.
2. Declare a [DxRangeSelectorChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelectorChart) object.
3. Add an appropriate series object to chart markup and populate the chart with arguments and values.

In this demo, the Range Selector uses an area series. When you select a range on the scale, the component raises the [DxRangeSelector.ValueChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxRangeSelector.ValueChanged) event and obtains values associated with the current selected range. These values define the axis visual range in a separate [DxChart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component.
