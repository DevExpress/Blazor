The Toast component supports four theme modes (`Dark`, `Light`, `Pastel`, and `Saturated`) and the following notification styles:

* `Danger`
* `Info`
* `Primary`
* `Success`
* `Warning`

You can combine these settings to customize toast appearance as needed.

In this demo, the [ShowToast](https://docs.devexpress.com/Blazor/DevExpress.Blazor.IToastNotificationService.ShowToast.overloads) method displays toasts at runtime. The method accepts a [ToastOptions](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ToastOptions) object as a parameter. This object's [ToastOptions.RenderStyle](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ToastOptions.RenderStyle) and [ToastOptions.ThemeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ToastOptions.ThemeMode) properties define toast appearance.

You can use [RenderStyle](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToastProvider.RenderStyle) and [ThemeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToastProvider.ThemeMode) properties at the [DxToastProvider](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToastProvider) level to specify common style settings for toasts used across your DevExpress-powered Blazor app.

Toast notifications appear with a predefined animation effect specified by the [AnimationType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToastProvider.AnimationType) property. You can select one of the following animation types: `Slide`, `Fade`, or `SlideAndFade`. 
