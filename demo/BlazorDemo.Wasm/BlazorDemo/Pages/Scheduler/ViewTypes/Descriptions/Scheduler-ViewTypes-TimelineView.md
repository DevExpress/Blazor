The [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component displays appointments as horizontal bars along timescales in the **Timeline View**.

To show the **Timeline View**, add the [DxSchedulerTimelineView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView) component to the markup. This component includes the following settings that allows you to customize the view:

* [CellMinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.CellMinWidth) — Specifies the minimum width of a single timescale division, in pixels.
* [Duration](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.Duration) — Specifies the time interval displayed in the view.
* [Scales](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.Scales) — Specifies a collection of timescales displayed in the view.
* [SnapToCellsMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.SnapToCellsMode) — Specifies how appointments snap to time cells.

In this demo, the [Duration](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.Duration) property specifies that view displays 48-hours period, the [CellMinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.CellMinWidth) property specifies the minimum division width equal to 80 pixels, and the [Scales](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView.Scales) property declares two scales for days and hours.
