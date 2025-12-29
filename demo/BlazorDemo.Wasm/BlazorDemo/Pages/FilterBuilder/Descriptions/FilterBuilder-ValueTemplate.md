The DevExpress Blazor [Filter Builder](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilder) allows you to specify templates used for field values:

* [ValueDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilderField.ValueDisplayTemplate) — Customizes content and appearance of field value captions.
* [ValueEditTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFilterBuilderField.ValueEditTemplate) — Allows you to replace an auto-generated value editor with custom content.

The templates implement the `context` parameter that includes [DisplayText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.FilterBuilderValueDisplayTemplateContext.DisplayText) and [Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.FilterBuilderValueDisplayTemplateContext.Value) properties.

This demo uses value-related templates for both the **Owner** field (to allow user input) and the **Status** field (to display values with icons).
