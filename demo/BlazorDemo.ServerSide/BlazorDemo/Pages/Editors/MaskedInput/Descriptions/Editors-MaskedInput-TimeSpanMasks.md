Our Blazor [Time span](https://docs.devexpress.com/Blazor/404167/data-editors/masks/time-span-masks) masks allow users to enter only time intervals. Users can navigate between mask sections and increase/decrease section values using the Up/Down arrow keys and the mouse wheel.

The [Masked Input](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1) component activates the time span mask type once you bind the component's [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.Value) property to a **TimeSpan** object. To enable this mask type in other usage scenarios, set the component's [MaskMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.MaskMode) property to `TimeSpan`. Once set, assign a mask pattern to the [Mask](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.Mask) property to apply a mask, and use the [DxTimeSpanMaskProperties](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeSpanMaskProperties) component to customize mask appearance and behavior.

Use the settings available in this demo to explore different mask modes:

* **Mask** — Specifies the mask pattern.
* **Caret Mode** — Specifies whether to automatically move the caret to the next editable section once you complete input within a mask section (`Advancing` mode) or to move focus manually (`Regular` mode).
* **Cascading Section Updates** — Specifies whether to increase or decrease the value of the previous or next mask section once you change a section's value with the Up/Down arrow key (or the mouse wheel) and the value passes the minimum or maximum threshold.
