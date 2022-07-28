In this demo, the [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component displays the entire week, including non-work days, in the **Week View**.

To show the **Week View**, add the [DxSchedulerWeekView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerWeekView) component to the markup. This component includes the following settings that allow you to customize the view:


* [ShowWorkTimeOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.ShowWorkTimeOnly) — Specifies whether the scheduler displays only working hours.
* [SnapToCellsMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.SnapToCellsMode) — Specifies how appointments snap to time cells.
* [TimeIndicatorVisibility](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.TimeIndicatorVisibility) — Specifies when to show the current time indicator.
* [TimeScale](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.TimeScale) — Specifies the appointment slot time interval.
* [VisibleTime](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.VisibleTime) — Specifies the visible time interval.
* [WorkTime](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.WorkTime) — Specifies the working time interval.


In this demo, the [ShowWorkTimeOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.ShowWorkTimeOnly) property is specified to display working hours only in the scheduler.