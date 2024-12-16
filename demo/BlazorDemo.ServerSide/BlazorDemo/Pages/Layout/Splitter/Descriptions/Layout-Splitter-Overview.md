The DevExpress Blazor [Splitter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitter) component allows you to divide web page content into multiple resizable and collapsible panes. Splitter panes ([DxSplitterPane](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane) objects) are stored in a [Panes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitter.Panes) collection. The component ships with the following capabilities:

**Horizontal and vertical pane orientation**  
Our Splitter component displays a single-level stack of panels. Use the [Orientation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitter.Orientation) property to specify pane stack direction.

**Hierarchical pane structure**  
To create multilevel panes, insert an additional Splitter component into the pane content area.

**Pane size**  
Use the [Size](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.Size) property to specify vertical pane width/horizontal pane height. When the [AllowResize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.AllowResize) property is set to `true`, users can resize the pane. Use [MinSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.MinSize) and [MaxSize](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.MaxSize) properties to restrict changes to pane size.

**Expand and Collapse Panes**  
Set a pane's [AllowCollapse](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.AllowCollapse) property to `true` to collapse the pane. Use the [Collapsed](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.Collapsed) property to determine pane collapse state. When pane state changes, the Splitter raises the [CollapsedChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSplitterPane.CollapsedChanged) event.

**Keyboard Navigation**  
The Splitter component supports keyboard navigation. Press the Tab key or Shift+Tab to focus the Splitter separator, then use Arrow keys to move the separator and the Enter key to expand/collapse the adjacent pane.
