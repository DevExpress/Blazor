Use the following events to customize available user actions within our Blazor [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) control (creating, editing, dragging, and resizing appointments):

* [AppointmentUpdating](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentUpdating)
* [AppointmentInserting](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentInserting)
* [AppointmentStartDragging](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentStartDragging)
* [AppointmentStartResizing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentStartResizing)
* [AppointmentFormShowing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentFormShowing)

In this demo, we display appointment information for 3 individuals (Resources). Appointment modifications (insert, update, drag, resize) are restricted to the "Current user". For instance, if you select Janet Leverling within the "Current user" field, you will not be able to modify appointments for Nancy Davolio and Andrew Fuller. In addition, appointments cannot be moved outside standard work hours (9:00AM to 5:30PM). Should you move an appointment outside standard work hours, the operation will be cancelled, and an error message will be displayed on-screen).