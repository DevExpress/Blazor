**Note**: Before adding file upload capabilities to your Blazor app, make certain to institute necessary security-related processes (to avoid risks and control unauthorized file operations).

The File Input component allows users to select one or more files and gives you direct and secure access to selected files in Razor code. You can upload selected files, send them to another destination, save them to the file system, or display file content on a web page.

Users can select files in the Open File dialog or drag & drop files to the drop zone. The [FilesUploading](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.FilesUploading) event occurs once an upload operation begins. Handle this event to access selected files and call a file's [OpenReadStream](https://docs.devexpress.com/Blazor/DevExpress.Blazor.IFileInputSelectedFile.OpenReadStream(System.Decimal-System.Threading.CancellationToken)) method to read file content.

This demo implements an external **Select File** button and a drop zone container for the File Input component. When the file list is empty, the File Input component is hidden. To customize the component's appearance and behavior, the demo uses the following API members:

* [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.Visible) — Specifies whether the component is visible.
* [SelectedFilesChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.SelectedFilesChanged) — Fires when the file list changes.
* [ExternalSelectButtonCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.ExternalSelectButtonCssSelector) — Specifies the CSS selector of a button or HTML element that invokes the Open File dialog.
* [ExternalDropZoneCssSelector](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.ExternalDropZoneCssSelector) — Specifies the CSS selector of a container or HTML element where to drop the files.
* [ExternalDropZoneDragOverCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFileInput.ExternalDropZoneDragOverCssClass) — Specifies the CSS class applied to the drop zone when users drag files over it.
