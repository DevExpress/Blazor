The DevExpress Blazor Search Box component updates its associated [Text](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSearchBox.Text) property after a user modifies search text. Use the [BindValueMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSearchBox.BindValueMode) property to specify when updates should occur. The following modes are available to you:

* `OnLostFocus` (default) — The editor’s value is updated after the editor loses focus.
* `OnInput` — The editor’s value is updated whenever a user enters text.
* `OnDelayedInput` — The editor’s value is updated (with a [delay](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSearchBox.InputDelay)) once a user modifies values.
