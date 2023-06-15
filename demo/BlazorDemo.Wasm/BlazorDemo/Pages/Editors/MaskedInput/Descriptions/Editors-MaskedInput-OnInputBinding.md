You can [bind](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor#bind) the editor's [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.Value) property to a field. If a user changes the input value, the editor updates its `Value` property. Use the [BindValueMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.BindValueMode) property to specify when the update should happen. The following modes are available:

* `OnLostFocus` (default) — The editor value is updated after the editor loses focus.
* `OnInput` — The editor value is updated whenever a user types.
* `OnDelayedInput` — The editor value is updated with a [delay](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.InputDelay) after a user makes changes.
