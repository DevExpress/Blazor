DevExpress Blazor [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows users to zoom a specific chart region. To activate this capability, set the [AllowDragToZoom](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.AllowDragToZoom) property to `true`. To pan the chart when zoomed, drag the mouse while pressing the specified [PanKey](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.PanKey). In this demo, press Shift to pan.

You can also use the [DxChartZoomAndPanDragBoxStyle](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanDragBoxStyle) object to customize appearance of the drag (selection) box. Customizable settings include [Color](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanDragBoxStyle.Color) and [Opacity](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanDragBoxStyle.Opacity).

When the [AllowDragToZoom](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.AllowDragToZoom) property is set to `false`, users can pan the chart with the mouse or use touch gestures without pressing any key.

When you zoom or pan the chart, axis visual ranges change. The DevExpress Blazor [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component allows you to react to those changes using the [VisualRangeChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.VisualRangeChanged) event. You can use the following methods to modify visual ranges:

* [ResetVisualRange](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.ResetVisualRange) — Resets visual ranges for all axes to match a data range. 
* [SetArgumentAxisVisualRange](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.SetArgumentAxisVisualRange(System.Collections.Generic.List-System.Object-)) — Sets the visual range for the argument axis.
* [SetValueAxisVisualRange](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.SetValueAxisVisualRange(System.Collections.Generic.List-System.Object--System.String)) — Sets the visual range for a specific value axis.

In this demo, click the **Reset Zoom** button to reset visual ranges for both argument and value axes.
