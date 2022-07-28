Our Blazor [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component allows you to assign [resources](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler#resources) to individual appointments/events. Resources allow you to display schedules across multiple columns. For example, you can create a resource item for each employee and then group appointments by this resource.

The DevExpress Blazor Scheduler component includes a drop-down [Resource Navigator](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ResourceNavigatorVisible) window. Use this window to hide or display resource groups as needed.

This demo illustrates how to easily group scheduled appointments by resource. When appointments are grouped by a resource and the Scheduler component displays multiple dates and resources, date headers are grouped under resource headers.

To group appointments by resource, set the [GroupType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.GroupType) property to `Resource`.
