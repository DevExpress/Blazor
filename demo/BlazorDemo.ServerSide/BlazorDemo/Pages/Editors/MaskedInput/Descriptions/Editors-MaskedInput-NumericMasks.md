Use the [Numeric](https://docs.devexpress.com/Blazor/402514/data-editors/masked-input/numeric-masks) mask type when you want to restrict input to numeric values. You can use predefined mask patterns or [standard numeric .NET formats](https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings) to specify the mask. Note that display values depend on the current culture. For example, the same input mask may define different settings for the U.S. and Germany ( currency symbol, thousand separator, precision, and so on).

Masked Input activates the numeric mask type if you bind the component’s [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.Value) property to a numeric object. To enable this mask type in other cases, set the component’s [MaskMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1.MaskMode) property to MaskMode.Numeric.

The **Mask** combobox and **Culture** radio button specify the mask pattern and current culture, respectively.

