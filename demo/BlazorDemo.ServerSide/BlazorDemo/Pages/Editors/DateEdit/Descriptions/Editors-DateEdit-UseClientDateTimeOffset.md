DevExpress Blazor [Date Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1) uses the time zone on the client to display and set DateTime values correctly - even if the server resides in a different time zone.

Our Blazor [Date Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1) also checks the Offset part of *DateTimeOffset* values and converts such values to the client time zone. To view the impact of the client time zone offset in this demo, change the time zone on your local machine.

To disable conversion at the project level, set the [CompatibilitySettings.IgnoreClientDateTimeOffsetInDateEdit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.CompatibilitySettings.IgnoreClientDateTimeOffsetInDateEdit) property to `true`.
