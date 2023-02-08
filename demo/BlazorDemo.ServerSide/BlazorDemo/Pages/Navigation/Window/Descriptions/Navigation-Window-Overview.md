Our Blazor [Window](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow) component allows you to display a non-modal window in your application. You can use it to display additional information or task progress, implement search dialogs, gather information from users, or ask for confirmation.

The window consists of three elements: header, body, and footer. The footer is initially hidden. You can set the [ShowFooter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.ShowFooter) property to `true` to display the footer. 

The [HeaderText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.HeaderText), [BodyText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.BodyText), and [FooterText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.FooterText) properties specify text displayed in the Window elements.

To show or close the Window in code, implement two-way binding for the [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.Visible) property. You can also use the [ShowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.ShowAsync(System.Threading.CancellationToken)), [ShowAtAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.ShowAtAsync.overloads), and [CloseAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.CloseAsync(System.Threading.CancellationToken)) methods. 

Users can close a Window in the following ways:

- Click the Close button. The button is shown when the [ShowCloseButton](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.ShowCloseButton) is set to `true`. 
- Press Escape. You can set the [CloseOnEscape](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxWindow.CloseOnEscape) property to `false` to disable this capability.
