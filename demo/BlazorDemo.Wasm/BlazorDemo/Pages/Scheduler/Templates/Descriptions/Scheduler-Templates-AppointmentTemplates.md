The DevExpress [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) allows you to use templates to customize the appearance of individual appointments:

*   [HorizontalAppointmentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.HorizontalAppointmentTemplate) - applied to [all-day appointments](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerAppointmentItem#all-day-appointment) that span an entire day or multiple days (displayed horizontally in the all-day panel).
*   [VerticalAppointmentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.VerticalAppointmentTemplate) - applied to other appointments (displayed vertically).

These properties obtain a [DxSchedulerAppointmentView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerAppointmentView) object that contains information about appointment settings. To access this object, use the template's **context** parameter.

To define appointment appearance, use HTML markup within the **HorizontalAppointmentTemplate** and **VerticalAppointmentTemplate** tags.
