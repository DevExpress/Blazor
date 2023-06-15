You can fully customize tooltips that appear on-screen when a user clicks an appointment/event. Use our [AppointmentTooltipHeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentTooltipHeaderTemplate) and [AppointmentTooltipTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentTooltipTemplate) properties to customize a tooltip's header and body. Use the `context` parameter within property markup to access appointment data. This parameter returns a [SchedulerAppointmentTooltipInfo](https://docs.devexpress.com/Blazor/DevExpress.Blazor.SchedulerAppointmentTooltipInfo) object. 

Our Blazor Scheduler component allows you to add the following predefined buttons to a tooltip and its header:

* [DxSchedulerCloseAppointmentButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerCloseAppointmentButton)
* [DevExpress.Blazor.DxSchedulerCloseRecurrenceSettingsFormButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerCloseRecurrenceSettingsFormButton)
* [DevExpress.Blazor.DxSchedulerDeleteAppointmentButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDeleteAppointmentButton)
* [DevExpress.Blazor.DxSchedulerDiscardAppointmentChangesButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDiscardAppointmentChangesButton)
* [DevExpress.Blazor.DxSchedulerRestoreAppointmentOccurrenceButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerRestoreAppointmentOccurrenceButton)
* [DevExpress.Blazor.DxSchedulerShowAppointmentCompactFormButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerShowAppointmentCompactFormButton)
* [DevExpress.Blazor.DxSchedulerShowAppointmentEditFormButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerShowAppointmentEditFormButton)

If our predefined buttons do not address your requirements, you can create [custom buttons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler#custom-buttons) as requirements dictate. 

You can also use the [ShowAppointmentTooltip](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ShowAppointmentTooltip) property to display/hide a tooltip.