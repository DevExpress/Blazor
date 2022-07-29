The [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component can display appointments by month or by multiple months in the **Month View**.

To show the **Month View**, add the [DxSchedulerMonthView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView) component to the markup. This component includes the following settings that allow you to customize the view:

* [CellMinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.CellMinWidth) — Specifies the minimum width of a day cell in the view, in pixels.
* [MonthCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.MonthCount) — Specifies the number of months displayed in the view.
* [ShowWorkDaysOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.ShowWorkDaysOnly) — Specifies whether the scheduler displays only work days in the view.
* [SnapToCellsMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.SnapToCellsMode) - Specifies how appointments snap to time cells. 

In this demo, the [MonthCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.MonthCount) property is set to `1` to display a single month, the [ShowWorkDaysOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.ShowWorkDaysOnly) property is set to `true` to display work days only, and the [CellMinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.CellMinWidth) property specifies the minimum cell width equal to 120 pixels.

