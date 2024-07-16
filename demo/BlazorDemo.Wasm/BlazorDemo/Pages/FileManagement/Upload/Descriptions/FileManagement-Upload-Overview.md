DevExpress Blazor UI Component Library includes two components that allow you to handle file upload: [DxUpload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload) and [DxFileInput](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput). Both these components allow you to upload files to a server, send them to another destination, or save them to the file system. The key difference between these components is that the Upload component requires creating a separate web API controller to upload files, while the File Input component gives you direct and secure access to selected files in Razor code.

The [Upload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload) component allows users to select files in the open file dialog or drag and drop files onto the drop zone. The main Upload API members are listed below:

*   [Name](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.Name) — Required to access uploaded files on the server.
*   [UploadUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.UploadUrl) — Specifies a target URL for the upload request.
*   [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.Visible) — Specifies whether the component is visible.
*   [SelectedFilesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.SelectedFilesChanged) — Fires when the file list is changed.
*   [ExternalSelectButtonCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.ExternalSelectButtonCssSelector) — Specifies the CSS selector of a button or HTML element that invokes the open file dialog.
*   [ExternalDropZoneCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.ExternalDropZoneCssSelector) — Specifies the CSS selector of a container or HTML element where to drop the files.
*   [ExternalDropZoneDragOverCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.ExternalDropZoneDragOverCssClass) — Specifies the CSS class that is used for a drop zone when users drag files over it.

This demo illustrates how to implement the external **Select File** button and drop zone container. The [Upload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload) component is hidden when the file list is empty.

To maintain the highest possible security posture, we do not include the full implementation of the Upload controller. To incorporate secure file upload operations in your web app, we recommend that you add different validation types to upload controller code as described in the following help section: [Validation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload#validation). For information on controller implementation code for different file upload scenarios, refer to the following Microsoft article: [File Upload Scenarios](https://learn.microsoft.com/en-us/aspnet/core/mvc/models/file-uploads?view=aspnetcore-8.0#file-upload-scenarios).
