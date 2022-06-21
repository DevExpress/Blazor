From customized newsletters, to personalized reports and letters, mail merge support within the DevExpress Blazor Rich Text Editor can address a variety of business requirements. Our mail merge engine allows you to bind the Blazor Rich Text Editor to an external data source and preview dynamic content within a document (template) prior to final mail merge operations.

To initiate merge operations, assign a data source to the [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxMailMergeSettings.Data) property (this will enable items within the **Mail Merge** tab). Once enabled, users can perform the following actions:

* Insert merge fields from the bound data source.
* View merged data.
* Navigate through data records.
* Merge the document and download results.

Our [MailMergeSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.DxRichEdit.MailMergeSettings) property allows you to access mail merge settings. Call the **MailMergeAsync** [method overload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.RichEdit.Document.MailMergeAsync.overloads) to initialize mail merge operations and generate the appropriate document(s).