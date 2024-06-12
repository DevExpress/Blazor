The DevExpress [HTML Editor](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditor) for Blazor supports "mentions". This feature allows a user to reference others in text or conversation threads. When a user types a [predefined marker](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention.Marker), the editor displays a drop-down list of available names. Our HTML Editor allows you to incorporate multiple mention lists. To identify the appropriate mention list, use a unique marker.

To create and configure a mention list:

1. Add a [DxHtmlEditorMention](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention) object to the [mention collection](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMentions).
1. Use the [DxHtmlEditorMention.Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention.Data) property to specify the data source used for mentions.
1. Specify the [DisplayFieldName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention.DisplayFieldName) property to obtain display values for mentions from data source fields.
1. Use the [SearchFieldNames](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention.SearchFieldNames) property to enable search operations against mentions.
1. *Optional*. Use [SearchMinLength](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention.SearchMinLength) and [SearchDelay](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxHtmlEditorMention.SearchDelay) properties to configure search settings.
