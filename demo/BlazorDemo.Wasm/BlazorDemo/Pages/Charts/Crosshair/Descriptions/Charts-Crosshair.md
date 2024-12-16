The DevExpress Blazor [Chart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1) component supports [crosshairs](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshair) (vertical and horizontal lines centered on a data point). Crosshairs help users identify series point values in a precise manner. When enabled, the crosshair follows the cursor and snaps to the nearest series point.

Follow the steps below to enable and configure crosshairs:

1. Add a [DxChartCrosshair](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshair) object to chart markup and set the [DxChartCrosshair.Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshair.Enabled) property to `true`.
2. Configure the [DxChartCrosshair](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshair) object to specify common crosshair settings (add [labels](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshairLabel), specify the line color, opacity, width, and style).
3. *Optional*. Specify individual settings for [horizontal](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshairHorizontalLine) and [vertical](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartCrosshairVerticalLine) crosshair lines.
