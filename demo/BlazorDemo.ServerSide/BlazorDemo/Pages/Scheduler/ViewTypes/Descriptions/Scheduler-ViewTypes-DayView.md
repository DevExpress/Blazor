The [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component can display a single day or multiple consecutive days in the **Day View**.

To show the **Day View**, add the [DxSchedulerDayView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDayView) component to the markup. This component includes the following settings that allow you to customize the view:

* [DayCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.DayCount) — Specifies the number of days displayed in the view.
* [ShowWorkTimeOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.ShowWorkTimeOnly) — Specifies whether the scheduler displays only working hours.
* [SnapToCellsMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.SnapToCellsMode) — Specifies how appointments snap to time cells. 
* [TimeIndicatorVisibility](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.TimeIndicatorVisibility) — Specifies when to show the current time indicator.
* [TimeScale](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.TimeScale) — Specifies the appointment slot time interval.
* [VisibleTime](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.VisibleTime) — Specifies the visible time interval.
* [WorkTime](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.WorkTime) — Specifies the working time interval.


In this demo, the [DayCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.DayCount) property is set to `1` to display a single day and the [ShowWorkTimeOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.ShowWorkTimeOnly) property is set to `true` to display working hours only in the scheduler.