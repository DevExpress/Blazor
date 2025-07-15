The DevExpress Blazor Scheduler component allows you to add predefined (standard) and custom toolbar buttons/items to your application (this demo includes a custom **ScaleDuration** button group with custom buttons).

To add predefined toolbar items/buttons, add the following objects to the [ToolbarItems](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ToolbarItems) tag:

* [DxSchedulerDateNavigatorToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDateNavigatorToolbarItem)
* [DxSchedulerNextIntervalToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerNextIntervalToolbarItem)
* [DxSchedulerPreviousIntervalToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerPreviousIntervalToolbarItem)
* [DxSchedulerResourceNavigatorToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerResourceNavigatorToolbarItem)
* [DxSchedulerTodayToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTodayToolbarItem)
* [DxSchedulerViewNavigatorToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerViewNavigatorToolbarItem)

To add custom buttons in your DevExpress-powered Blazor app, declare a [DxToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem) object and handle its [Click](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Click) event to execute custom commands. In this demo, the **ScaleDuration** button group consists of custom buttons.

Both predefined and custom toolbar items support base functionality – you can [change item position](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.Alignment), create [button groups](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem#item-groups), [assign icons](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxToolbarItemBase.IconCssClass), etc. Refer to the following class description for additional information and examples: [DxToolbarItem](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem).
