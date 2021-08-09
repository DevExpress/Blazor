The [Date-Time](https://docs.devexpress.com/Blazor/402515/data-editors/masks/date-time-masks) mask type allows users to enter date and/or time values. You can use predefined mask patterns or [standard date and time .NET formats](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings) to specify the mask. Note that display values depend on the current culture.

Masked Input activates the date-time mask type if you bind the component’s [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.Value) property to a DateTime object. To enable this mask type in other scenarios, set the [MaskMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.MaskMode) parameter to MaskMode.DateTime.

The **Mask**, **Caret Mode**, and **Culture** settings specify additional mask properties.
