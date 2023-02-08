The DevExpress Blazor Rich Text Editor ships with a [built-in spell check service](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.SpellCheck.SpellCheckExtensions) that can detect spelling errors and suggest corrections. Review demo source code to learn how you can enable and configure this service as business needs dictate. 

Configuration involves two steps: 

- Register a spell check service. <br/>
  Call the [AddSpellCheck](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.SpellCheck.SpellCheckExtensions.AddSpellCheck(IDevExpressBlazorBuilder--Action-SpellCheckOptions-)) extension method. In this method call, you can customize service [options](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.SpellCheck.SpellCheckOptions).

- Enable spell check within the Rich Text Editor control. <br/>
  Set the component's [CheckSpelling](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.CheckSpelling) property to `true`. 

The [DocumentCulture](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.DocumentCulture) property specifies the culture name for an open document. Depending on document culture, the service determines which [dictionaries](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.SpellCheck.SpellCheckOptions.Dictionaries) to use.

If the built-in service does not address your requirements, you can implement and use a [custom spell check service](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.ISpellCheckService).
