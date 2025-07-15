The DevExpress Blazor [Message Box](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMessageBox) component allows you to display alert or confirmation dialogs in your application.

You can place the component in markup and display it on demand or use the dialog service ([IDialogService](https://docs.devexpress.com/Blazor/DevExpress.Blazor.IDialogService)) to create message boxes at runtime (see the [Dialog Service](MessageBox#DialogService) demo). 

In this demo, the [DxMessageBox](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMessageBox) component is declared in markup. The [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMessageBox.Visible) property controls message box visibility. Implement two-way binding for the property to display and close the message box in code. When a user clicks the demo area, the property is set to true and the message box appears on-screen. When a user closes the dialog, the component updates the `Visible` property value accordingly.

To process dialog button clicks, handle the [Closed](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMessageBox.Closed) event. The event parameter returns a Boolean value:

* `true` if a user clicks the **OK** (**Show details...** in this demo) button.
* `false` if a user clicks the **Cancel** (**OK** in this demo) button or closes the dialog in another way: click the Close button in the header, press Escape, or click outside the box boundaries.