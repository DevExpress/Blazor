The DevExpress Blazor Scheduler allows you to customize appointment appearance using the following templates:

* [HorizontalAppointmentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.HorizontalAppointmentTemplate) is applied to [all-day appointments](https://docs.devexpress.com/Blazor/404770/components/scheduler/appointments#all-day-appointment) (displayed horizontally in the all-day panel).
* [VerticalAppointmentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxSchedulerDayViewBase.VerticalAppointmentTemplate) is applied to other appointments (displayed vertically).

These templates accept a [DxSchedulerAppointmentView](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerAppointmentView) object as the `context` parameter. Use this object to access appointment data. In this demo, templates use custom colors to render appointments.

Appointment templates may affect drag & drop responsiveness. Since the component renders templates on the server side, continuous client-server communication can affect performance. To maintain responsiveness, this demo uses `Client` mode for drag & drop operations ([AppointmentDragMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentDragMode) property). When `Client` mode is used, the Scheduler component displays a tooltip to indicate the target position rather than re-rendering templated appointments. You can use the combo box to switch between modes.

