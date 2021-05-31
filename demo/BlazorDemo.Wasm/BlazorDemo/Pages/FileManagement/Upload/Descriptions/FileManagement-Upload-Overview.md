The [Upload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload) component allows users to upload files to the server. Users can select files in the open file dialog or drag and drop files to the drop zone.

The main Upload API members are listed below:

*   [Name](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.Name) - Required to access uploaded files on the server.
*   [UploadUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.UploadUrl) - Specifies a target URL for the upload request.
*   [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.Visible) - Specifies whether the component is visible.
*   [SelectedFilesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.SelectedFilesChanged) - Fires when the file list is changed.
*   [ExternalSelectButtonCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.ExternalSelectButtonCssSelector) - Specifies the CSS selector of a button or HTML element that invokes the open file dialog.
*   [ExternalDropZoneCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.ExternalDropZoneCssSelector) - Specifies the CSS selector of a container or HTML element where to drop the files.
*   [ExternalDropZoneDragOverCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.ExternalDropZoneDragOverCssClass) - Specifies the CSS class that is used for a drop zone when users drag files over it.

This demo illustrates how to implement the external **Select File** button and drop zone container. The [Upload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload) component is hidden when the file list is empty.
