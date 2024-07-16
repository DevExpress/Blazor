**Note**: Before adding file upload capabilities to your Blazor app, make certain to institute necessary security-related processes (to avoid risks and control unauthorized file operations).

DevExpress Blazor UI Component Library includes two components that allow you to handle file upload: [DxUpload](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload) and [DxFileInput](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput). Both these components allow you to upload files to a server, send them to another destination, or save them to the file system. The key difference between these components is that the Upload component requires creating a separate web API controller to upload files, while the File Input component gives you direct and secure access to selected files in Razor code.

With the File Input component, users can select files in the Open File dialog or drag and drop files onto the drop zone. The [FilesUploading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.FilesUploading) event occurs once an upload operation begins. Handle this event to access the selected files and call a file's [OpenReadStream](https://docs.devexpress.com/Blazor/DevExpress.Blazor.IFileInputSelectedFile.OpenReadStream(System.Decimal-System.Threading.CancellationToken)) method to read file content.

This demo implements an external **Select File** button and a drop zone container for the File Input component. When the file list is empty, the File Input component is hidden. To customize the component's appearance and behavior, the demo uses the following API members:

* [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.Visible) — Specifies whether the component is visible.
* [SelectedFilesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.SelectedFilesChanged) — Fires when the file list changes.
* [ExternalSelectButtonCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.ExternalSelectButtonCssSelector) — Specifies the CSS selector of a button or HTML element that invokes the Open File dialog.
* [ExternalDropZoneCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.ExternalDropZoneCssSelector) — Specifies the CSS selector of a container or HTML element where to drop the files.
* [ExternalDropZoneDragOverCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.ExternalDropZoneDragOverCssClass) — Specifies the CSS class applied to the drop zone when users drag files over it.
