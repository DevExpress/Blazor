Our Blazor [Scheduler](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler) component allows you to assign [multiple resources](https://docs.devexpress.com/Blazor/404769/components/scheduler/resources#multiple-resources) to an appointment. This feature can help address a variety of usage scenarios including meetings with multiple participants, group events, or services that require coordination among various resources.

To enable this feature within your DevExpress-powered Blazor app, you should:

1. Set the [EnableMultipleResources](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDataStorage.EnableMultipleResources) property to 'true'.
2. Add a new data field (`Resources`) to an appointment’s source object. 
3. Map this field to the `ResourceId` appointment property.

If you group appointments by resource, multi-resource appointments appear under all linked resources.