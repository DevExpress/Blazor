# NuGet Package Change Log

Version history of the "DevExpress.Blazor" NuGet package is listed below.

# 20.1.7

### Support for .NET Core 3.1.8 
In this version, we added support for [.NET Core 3.1.8](https://devblogs.microsoft.com/dotnet/net-core-september-2020/).

### DevExpress Project Templates
You can now create Blazor Server and WebAssembly apps based on DevExpress project templates that include:

* References to the DevExpress Blazor NuGet package and DevExpress resources
* The DevExpress Blazing Berry theme
* Sidebar navigation based on the TreeView component
* The Data Grid component

[Documentation](https://docs.devexpress.com/Blazor/401057/getting-started/create-an-application#devexpress-templates)

### Data Grid Enhancements
You can customize text displayed in the pop-up Edit Form's header. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.PopupEditFormHeaderText))

### Data Editors Enhancements

* Date Edit
    * The new [CustomDisabledDate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.CustomDisabledDate) event allows you to disable selection of specific dates in the component’s calendar. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.CustomDisabledDate) | [Demo](https://demos.devexpress.com/blazor/DateEdit#DisabledDates))
    * You can now specify a custom null value for the Date Edit. This value is applied to the editor each time a user clears the Date Edit's content. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.NullValue))
* Calendar - The new [VisibleDateChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar-1.VisibleDateChanged) event allows you to handle changes to the month and year in the component.
* ComboBox, TagBox, ListBox - You can now specify custom column captions for multi-column editors. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn.Caption) | [Demo](https://demos.devexpress.com/blazor/ComboBox#MultipleColumns))
* Disabled state. The new [Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataEditorBase-2.Enabled) property allows you to disable a data editor. The disabled editor does not respond to user interactions and users cannot change the editor's value/state. 

### Form Layout Enhancements
* Disabled state for DevExpress editors in Form Layout items. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem.Enabled))
* Read-only mode for DevExpress editors in Form Layout items. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem.ReadOnly))

### Toolbar Enhancements
You can now control whether the Toolbar automatically closes the sub-menu after a user clicks this menu’s item. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbarItem.CloseMenuOnClick))

### Resolved Issues
See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.7&endBuildName=&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.1.7

### Breaking Change
[Date Edit - The DateEdit_AdaptiveDatePickerNotification localization string has been replaced with the DateEdit_DisabledDateNotification and DateEdit_OutOfRangeNotification strings](https://supportcenter.devexpress.com/ticket/details/t933584/)


# 20.1.6

### Support for .NET Core 3.1.7 and Blazor WebAssembly 3.2.1

In this version, we added support for [.NET Core 3.1.7](https://devblogs.microsoft.com/dotnet/net-core-august-2020/) and Blazor WebAssembly 3.2.1.

### New Memo Component

The new Memo component for Blazor has the following features:
 
* Data binding
* Custom size
* Resize modes
* Clear button
* Read-only state

[Demo](https://demos.devexpress.com/blazor/Memo) | [Documentation]( http://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo)

### Data Grid Enhancements

#### New Popup Edit Form

You can now edit row values in a pop-up Edit Form. ([Demo](https://demos.devexpress.com/blazor/GridEditData) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1#edit-data))

### Scheduler Enhancements

* Appointment Templates - Use templates to customize appointment appearance ([Demo](https://demos.devexpress.com/blazor/SchedulerTemplates#AppointmentTemplates) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler#templates))

* Custom Fields - Add custom data to Scheduler’s appointments, labels, and statuses ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler#custom-fields))

* New API properties that allow you to assign CSS classes to appointment labels and statuses ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerAppointmentLabelItem._members))

### Data Editors Enhancements

* ComboBox, TagBox, ListBox - Support for multiple columns ([Demo](https://demos.devexpress.com/blazor/ComboBox#MultipleColumns) | 
[Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxListEditorColumn))

* ComboBox, TagBox, ListBox - Binding to a data object field ([Demo](
https://demos.devexpress.com/blazor/ComboBox#ItemValues))

* Calendar enhancements
    
    * Validation support
    * Nullable DateTime support 
    * Binding to a single date ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar-1.SelectedDate))

* CheckBox, ComboBox, DateEdit, SpinEdit, TagBox - New [InputId](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.InputId) property

### Form Layout Enhancements

You can now assign [CSS classes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem.CssClass) to layout items and to captions of items, tab pages, and groups.

### Processing Events

Changed the delegate type from [Action](https://docs.microsoft.com/en-us/dotnet/api/system.action-1) to [EventCallback](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.eventcallback) in [multiple components](https://supportcenter.devexpress.com/ticket/details/T920147/specific-events-have-changed-their-delegate-type-from-action-to-eventcallback).

### Resolved Issues

Refer to [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.6&endBuildName=&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in 20.1.6.

### Breaking Changes

* [API members from the majority of base classes have been moved to descendant classes](https://supportcenter.devexpress.com/ticket/details/T921319)
* [Specific events have changed their delegate type from Action to EventCallback](https://supportcenter.devexpress.com/ticket/details/T920147)
* [Calendar - The DateExpression property has been replaced with the SelectedDateExpression and SelectedDatesExpression properties](https://supportcenter.devexpress.com/ticket/details/T900424)
* [Calendar - The DxCalendar class and specific API members have become generic-typed](https://supportcenter.devexpress.com/ticket/details/T900084)
* [The ComboBox, List Box, and TagBox components' API and declaration have been changed](https://supportcenter.devexpress.com/ticket/details/T921360)
* [Data Grid field-related properties have been renamed](https://supportcenter.devexpress.com/ticket/details/T921348)
* [Form Layout - The DxFormLayoutItem.CaptionFor property value is no longer assigned to the ID property of editors in the template](https://supportcenter.devexpress.com/ticket/details/T921344)
* [Pivot Grid - The PivotGridSummaryType.NotSet enumeration value has been removed and the SummaryType default value has been changed to Sum](https://supportcenter.devexpress.com/ticket/details/T917294)
* [The DxDataGridColumn.AllowSort and DxDataGridColumn.EditorVisible property's value type has been changed from DefaultBoolean to nullable Boolean](https://supportcenter.devexpress.com/ticket/details/T905067)

# 20.1.5

### Support for .NET Core 3.1.5  

In this version, we added support for [.NET Core 3.1.5](https://devblogs.microsoft.com/dotnet/net-core-june-2020-updates-2-1-19-and-3-1-5/).

### Data Grid Enhancements
* The ability to hide the Filter Row's editors for individual columns ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumn.AllowFilter))
* New ComboBox column features:
  * Filter modes ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridComboBoxColumn-1.FilteringMode))
  * Virtual render mode ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridComboBoxColumn-1.ListRenderMode))

### Data Editors Enhancements
* ComboBox, TagBox - Drop-down window’s width modes ([Demo](https://demos.devexpress.com/blazor/ComboBox#DropDownListWidth) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.DropDownWidthMode))
* Calendar, Date Edit - Min/max dates ([Demo](https://demos.devexpress.com/blazor/Calendar#DateRange) | [Documentation - MinDate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar-1.MinDate) | [Documentation - MaxDate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar-1.MaxDate))

### Other Enhancements
* Toolbar - Display a drop-down menu in a modal dialog 
([Demo](https://demos.devexpress.com/blazor/Toolbar#DropDownItems) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.DropDownDisplayMode))
* Upload
  * A response message received from the server ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.UploadHttpRequestInfo.ResponseTex))
  * A file's last modified date ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.UploadFileInfo.LastModified))

### Resolved Issues
Refer to [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.5&endBuildName=&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in 20.1.5.

### Breaking Changes
* [Data Grid - The filter row has become hidden by default](https://supportcenter.devexpress.com/ticket/details/T903275)
* [ComboBox and TagBox - The default width of the drop-down lists has been changed](https://supportcenter.devexpress.com/ticket/details/T899859)
* [Date Edit - The first day of a week has become culture-dependent](https://supportcenter.devexpress.com/ticket/details/T899965)

# 20.1.4

### Support for .NET Core 3.1.4 and Blazor WebAssembly 3.2.0  

In this version, we added support for the [.NET Core 3.1.4](https://devblogs.microsoft.com/dotnet/net-core-may-2020/) and the [Blazor WebAssembly 3.2.0 Release](https://devblogs.microsoft.com/aspnet/blazor-webassembly-3-2-0-now-available/).


### New Reporting Components *

With our 20.1.4 release, we added Blazor Reporting components with the following features:

* Document Viewer
  * Preview and print documents 		
  * Export to different formats (PDF, XLS, XLSX, RTF, DOCX, MHT, HTML, TXT, CSV, Image) 		
  * Navigation via buttons and bookmarks 		
  * Search support 		
  * Multi-page mode 		
  * Full screen mode


* Report Designer
  * Support for different report types (Table Report, Master-Detail Report,   *   *   * Invoice Report, Vertical Report, and so on) 		
  * Bind to data (SQL, JSON and Object data sources) 		
  * 20+ report controls, including Charts and Pivot Tables 		
  * Report Wizard 		
  * Data Source Wizard and Query Builder 		
  * Built-in Document Viewer 		
  * Data shaping and analytics 		
  * Parameters support 		
  * Data navigation 		
  * Appearance customization 	

[Demo - Document Viewer](https://demos.devexpress.com/blazor/DocumentViewer) | [Demo - Report Designer](https://demos.devexpress.com/blazor/ReportDesigner) | [Documentation](https://docs.devexpress.com/Blazor/401706/reporting)

\* **Important Note**: Though [DevExpress Reports](https://www.devexpress.com/subscriptions/reporting/) supports Blazor, it is not included in our Blazor UI component distribution. To use DevExpress Reports in your Blazor project or to replicate the functionality described below, you must purchase a DevExpress Subscription (*Reporting Subscription*, *ASP.NET Subscription*, *DXperience*, or *Universal*). For more information on what is included in our product subscriptions, refer to the [product matrix](https://www.devexpress.com/buy/net/).

### New Toolbar Component
The new Toolbar component for Blazor has the following features:

* Various button types 
  * Drop-down items
  * Checked/unchecked items 
  * Radio groups
  * Link items
* Button render and style customization
* Adaptive mode

[Demos](https://demos.devexpress.com/blazor/Toolbar) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar)

### New Context Menu Component
The new Context Menu component for Blazor with the following features:

* Data binding
* Unbound mode
* Item groups
* Item appearance customization

[Demos](https://demos.devexpress.com/blazor/ContextMenu) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu)

### Size Modes
The majority of DevExpress Blazor components now support three size modes defined in your Bootstrap theme: small, medium, and large. You can apply a size mode to an individual component (for example, a data editor or pager), all compatible components in a container (for example, Data Grid or Form Layout), or for the entire application. ([Documentation](https://docs.devexpress.com/Blazor/401784/common-concepts/customize-appearance/size-modes))

### Data Grid Enhancements
* Column chooser ([Demo](https://demos.devexpress.com/blazor/GridColumnChooser) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridColumnChooserToolbarItem))
* Header template ([Demo](https://demos.devexpress.com/blazor/GridToolbar) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.HeaderTemplate))

### Charts Enhancements
* Axis data type customization ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartAxisDataType))
* The VisibleChanged event for chart series ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartSeries.VisibleChanged))
* Ability to hide overlapped point labels ([Demo](https://demos.devexpress.com/blazor/ChartDynamicSeries) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.LabelOverlap))

### Data Editors Enhancements
* Display format ([Demo](https://demos.devexpress.com/blazor/DateEdit#DisplayFormat) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.DisplayFormat))
* CheckBox - Alignment ([Demo](https://demos.devexpress.com/blazor/CheckBox#Alignment) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1.Alignment))
* Spin Edit
  * Touch device usability enhancements ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1))
  * Custom increment values ([Demo](https://demos.devexpress.com/blazor/SpinEdit#CustomIncrement) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1.Increment))
  * Update the value when the input changes ([Demo](https://demos.devexpress.com/blazor/SpinEdit#BindValueOnInputChange) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1.BindValueMode))
  * Support for HTML attributes ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSpinEdit-1#html-attributes))
* Text Box 
  * Update the value when the input changes ([Demo](https://demos.devexpress.com/blazor/TextBox#BindValueOnInputChange) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxTextEditorBase.BindValueMode))
  * Support for HTML attributes ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextBox#html-attributes))
* ComboBox, Date Edit, TagBox 
  * Support for HTML attributes ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2#html-attributes))
  * Drop-down window direction ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDropDownBase-2.DropDownDirection))

### Resolved Issues
Refer to [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.4&endBuildName=&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in 20.1.4.

### Breaking Changes
* [The default size of some components has been changed](https://supportcenter.devexpress.com/ticket/details/t892888)
* [Data Grid - Format-related properties of the Spin Edit and Date Edit columns have been renamed](https://supportcenter.devexpress.com/ticket/details/T874276)
* [Date Edit - The default date format has become culture-dependent](https://supportcenter.devexpress.com/ticket/details/T874294)
* TreeView 
  * [Click on a node's expand/collapse button no longer invokes an action associated with a click on the node itself](https://supportcenter.devexpress.com/ticket/details/t875624)
  * [The TreeViewNodeInfo class has been moved to an internal namespace](https://supportcenter.devexpress.com/ticket/details/T878784)
* [Form Layout - The ValueEditingContext class has been renamed to ValueEditContext](https://supportcenter.devexpress.com/ticket/details/t882931)

# 19.2.4 Release

### .NET Core 3.1.2 Support

In this version, we added support for the [.NET Core 3.1.2](https://github.com/dotnet/core/blob/master/release-notes/3.1/3.1.2/3.1.2.md) update.

### New Upload Component

Our new Upload component for Blazor includes the following features:

* Chunk upload for large files
* Upload multiple files at once
* Drag-and-drop area for uploaded files
* File extension and size validation
* Instant upload
* Upload on a button click

[Demos](https://demos.devexpress.com/blazor/Upload) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload)

### Added

* Chart – Rotation ([Demo](https://demos.devexpress.com/blazor/ChartAxes#ChartRotation) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.Rotated))
* Calendar - Navigation through months, years, decades, and centuries ([Demo](https://demos.devexpress.com/blazor/Calendar) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar-1#select-a-date))

### Fixed

* Data Grid
  * [NullReferenceException occurs when DxCheckBox changes the ShowFilterRow property value](https://supportcenter.devexpress.com/ticket/details/T862009)
  * [NullReferenceException occurs if the grid is empty and DxDataGridComboBoxColumn is used with a hidden filter row](https://supportcenter.devexpress.com/ticket/details/T853567)
  * [Virtual scrolling does not work if the grid is bound to data via the CustomData property](https://supportcenter.devexpress.com/ticket/details/T854655)
  * [ComboBox does not keep the selected item while Grid records are edited if a ComboBox column is bound to a collection of custom objects](https://supportcenter.devexpress.com/ticket/details/t863709)
* [Drop-down editors in the Popup component are not displayed over the Popup's boundaries and cause scroll bars to appear instead.](https://supportcenter.devexpress.com/ticket/details/t860343)


### Breaking Changes

* [Data Grid – For combo box columns bound to a collection of custom objects, the RowUpdating(Async) and RowInserting(Async) event handlers now accept the entire selected item instead of the selected item's value](https://supportcenter.devexpress.com/ticket/details/t865261)
* [Upload - Changes in the UploadMode enumeration, AcceptedFileTypes property, and upload events](https://supportcenter.devexpress.com/ticket/details/t863515) (compared to [v19.2.4-Preview](#1924-preview))

# 19.2.4-Preview

### New Upload Component

Our new Upload component for Blazor includes the following features:

* Chunk upload for large files
* Upload multiple files at once
* Drag-and-drop area for uploaded files
* File extension and size validation
* Instant upload
* Upload on a button click

# 19.2.3 Release

> Please also explore new features and breaking changes introduced in [19.2.1 Beta](#1921-beta) and [19.2.2 Beta](#1922-beta) versions.

### New Bootstrap Theme
We created a new “Blazing Berry” theme for applications that are built using Bootstrap v4. This theme is now the default theme for our [online demos](https://demos.devexpress.com/blazor/).
 
### New Components
In this version, we added two new components to our DevExpress UI for Blazor:

* Button
* TagBox 

### Added
* Data Grid
  * Page size selector
  * The ability to limit the number of visible numeric buttons in a pager
  * Row preview section
  * New row initialization
  * Reload data in code
* Chart - The ability to specify an axis type
* Spin Edit - Hide spin buttons
* Pager -  The ability to limit the number of visible numeric buttons
* Popup
  * Footer template
  * Change the header's visibility in code
  * Change the component’s visibility in code
  * A scrollbar in the pop-up window’s content.

### Fixed
* [The Virtual Scrolling mode and the Master-Detail view do not work properly together.](https://github.com/DevExpress/Blazor/issues/75)

### Breaking Changes
* [Pager and Data Grid's Pager - The navigation mode was changed and the CollapseButtonCount property removed.](https://supportcenter.devexpress.com/internal/ticket/details/T851310)

### Known Issues
* [Drop-down editors in the Popup component are not displayed over the Popup's boundaries and cause scroll bars to appear instead.](https://supportcenter.devexpress.com/ticket/details/t860343/drop-down-editors-located-in-the-popup-component-cause-scroll-bars-instead-of-displaying)

# 19.2.2 Beta

### .NET Core 3.1.1 Support

In this version, we support [.NET Core 3.1.1](https://devblogs.microsoft.com/dotnet/net-core-january-2020/) that contains security and reliability fixes.

### Increased Stability

We polished features delivered in 19.2.1 Beta.

### Breaking Changes

* [Data Grid - The OptimizedMultipleSelectionChanged event has become asynchronous](https://supportcenter.devexpress.com/ticket/details/t851209)
* [Data Grid - The StartRowEdit, CancelRowEdit and SetDataRowSelectedByKey methods have become asynchronous](https://supportcenter.devexpress.com/ticket/details/t852758)

# 19.2.1 Beta

### Added

* Localization
* Data Grid 
  * Asynchronous data binding 
  * Binding to custom data sources
  * A CheckBox column
  * The Go to Page input box to jump to the corresponding page
* Scheduler - New events to handle CRUD operations (add, update, and remove appointments)
* Date Edit, Spin Edit, and Text Box - NullText support
* Pager - The Go to Page input box to jump to the corresponding page

### Fixed

* Data Grid
  * Incorrect styles are applied to multiple selected data rows
  * [The grid jumps in virtual scrolling mode](https://github.com/DevExpress/Blazor/issues/55)
  * [The clear button for the filter row editors is shown at an incorrect position if the horizontal scrollbar is shown](https://www.devexpress.com/Support/Center/Question/Details/T850224/datagrid-for-blazor-the-clear-button-for-the-filter-row-editors-is-shown-at-an-incorrect)
* [ComboBox - The "Value cannot be null. (Parameter 'accessor')" exception is thrown if the ListRenderMode property is set to Virtual](https://supportcenter.devexpress.com/ticket/details/T846352)
* Date Edit 
  * Dates BC (before Christ) lead to an exception
  * The Clear button is displayed when the component is bound to a non-nullable data type
  * [Clicking the "Today" button leads to the "Value cannot be null. (Parameter 'accessor')" error](https://supportcenter.devexpress.com/ticket/details/T829754)
* Spin Edit - Negative numbers lead to an exception when the component is bound to an unsigned numeric type
* [List Box - Items have an unnecessary border if the render mode is set to "Virtual" and checkboxes are shown](https://www.devexpress.com/Support/Center/Question/Details/T825718/list-box-for-blazor-items-have-an-unnecessary-border-if-the-render-mode-is-set-to)

### Breaking Changes

* [Location of DevExpress resources has been changed](https://supportcenter.devexpress.com/ticket/details/T850893)
* [Client-side Blazor applications now require calling the AddDevExpressBlazor method](https://supportcenter.devexpress.com/ticket/details/T850922)
* [DevExpress Blazor components no longer support .NET Standard 2.0 and .NET Core 3.0](https://supportcenter.devexpress.com/ticket/details/T851146)
* Data Grid
  * [Base column-related classes have become abstract](https://supportcenter.devexpress.com/ticket/details/T849926)
  * [The default navigation mode has been changed](https://supportcenter.devexpress.com/ticket/details/T851310)
* [Checkbox - Numeric values other than 0 and 1 are now interpreted as an indeterminate state](https://supportcenter.devexpress.com/ticket/details/T850998)
* [Pager - The default navigation mode has been changed](https://supportcenter.devexpress.com/ticket/details/T851310)

# 19.1.10 

### .NET Core 3.1 Support
In this version, we added support for the release of [.Net Core 3.1](https://devblogs.microsoft.com/dotnet/announcing-net-core-3-1/).

### New CheckBox Component
We added the following features to the new Blazor CheckBox component:

* Bind to any data type	 	
* Toggle switch mode
* Support for the indeterminate state
* Customizable appearance

### Added
* Data Grid 
  * Handle a row click
  * Cell and row HTML decoration
  * *Ctrl+click* to clear a column’s sort order 
* TreeView – Load child nodes on demand 	
* Date Edit – Support for null values 	
* The **Clear** button was added to the Text Box, Spin Edit, Date Edit, and ComboBox

### Fixed
* Data Grid
  * Users cannot edit grid rows if a data source is IQueryable 	
  * [Selection doesn't work correctly when the AutoMapper is used](https://github.com/DevExpress/Blazor/issues/54)	
  * [The RowInserting and RowUpdating events are raised if the "Close" button is clicked in a popup edit form](https://github.com/DevExpress/Blazor/issues/74)
* [Charts - The "System.ArgumentNullException: Value cannot be null. (Parameter 'source')" error occurs if data is provided to charts too late](https://supportcenter.devexpress.com/ticket/details/T828593) 	
* Date Edit
  * [The September 1, 2019 day cell is not displayed in the September month if the FirstDayOfWeek property is set to Monday](https://supportcenter.devexpress.com/internal/ticket/details/T832166)
  * Scroll speed depends on the browser when the component is in ScrollPicker mode 	
* [Form Layout - Focus an editor on a label click](https://github.com/DevExpress/Blazor/issues/58)



### Breaking changes

* [Date Edit has become generic-typed](https://supportcenter.devexpress.com/internal/ticket/details/t838351)


# 19.1.9 

### Added

* Data Grid - Save and restore the layout
* Date Edit - ScrollPicker mode
	
### Fixed
	
* Support tickets
  * https://supportcenter.devexpress.com/ticket/details/T821637
  * https://supportcenter.devexpress.com/ticket/details/T823526
  * https://supportcenter.devexpress.com/ticket/details/T823175
* Data Grid bugs
  * GroupIndex is not taken into account when the SortOrder property value is specified in the markup
  * The pager does not work properly when a user groups grid data and it changes the number of data pages
  * Column widths are calculated incorrectly when grid data is grouped and the navigation mode is set to VirtualScrolling 
  * The component does not switch to a previous page if a user deletes the last row on the last page
		
### Changed API

* [OnCustomizeSeriesPoint renamed to CustomizeSeriesPoint](https://supportcenter.devexpress.com/ticket/details/T826048)


# 19.1.8 

### Fixed

* https://supportcenter.devexpress.com/internal/ticket/details/T814205
* https://supportcenter.devexpress.com/internal/ticket/details/T815667
* https://supportcenter.devexpress.com/internal/ticket/details/T819540

### Added

* Data Grid 
  * API for managing the index of the current page (PageIndex and PageIndexChanged)
  * API for getting the current page count (PageCount and PageCountChanged)

* TreeView
  * Templates
  * Customizing the way how end-users can expand/collapse nodes 
  * Detecting whether the event triggering was caused by an API method call or not. 
  * Finding all nodes that satisfy the specified condition (predicate).
  * Getting the node's parent node information.

# 19.1.7

### Added

* Support for .NET Core 3.0 Release

# 0.4.1

### Fixed

* [Date Edit - Clicking a date does not work properly in Data Grid's Edit Form](https://github.com/DevExpress/Blazor/issues/45)
* Date Edit - The component does not prevent an internal calendar from changing a selected day in read-only mode
* Data Grid - A click on a grid header with *Ctrl* pressed opens a new tab in Firefox
* Data Grid - Grouping data by a ComboBox column outputs a column value to a group row instead of text
* Data Grid - Expanding a DateTime group does not display data rows
* Data Grid - A format string applied to a Spin Edit column does not affect a corresponding cell in a group row
* List Box - The component does not allow selecting a range of items with *Shift* pressed if the **ShowCheckboxes** property is set to **true**

# RC

### New Components
* Calendar
* List Box
* Popup

### Added
* Data Grid 
  * Bind to ExpandoObjects instances
  * Bind to complex data objects 
  * Filter Row enhancements
* Charts - New series types: Financial, Range, Pie, and Donut 

### Changed API
* *ComboBoxDataLoadMode {Default, VirtualScrolling}* renamed to *ListRenderMode {Entire, Virtual}*
* *DxComboBox.DataLoadMode* renamed to *DxComboBox.ListRenderMode*

# 0.3.3
 
### Added
* Support for .NET Core 3.0 Release Candidate 1

# 0.3.2
 
### Added
Form Layout    
* Build group layouts for different screen resolutions. Use the DxFormLayoutGroup class' ColSpanXX properties to specify the width of layout groups for different screens. 	
* Build tabbed layouts for different screen resolutions. Use the DxFormLayoutTabPages class' ColSpanXX properties to specify the width of layout tabs for different screens.
 
### Fixed
* [DevExpress/Blazor: Issue #40](https://github.com/DevExpress/Blazor/issues/40) 	
* [DevExpress/Blazor: Issue #43](https://github.com/DevExpress/Blazor/issues/43)

# 0.3.1

### Added
* Support for NET Core 3.0 Preview 9

# Beta 3 

### Added
* Data Grid
  * Multiple selection
  * Specify a column's position in code
  * Drag and drop column headers
  * Grouping 
  * Master-Detail view
* Scheduler - Appointment editing
* Text Box - Password mode
* All Data Editors - Read-only mode

### Changed API

* *DxDataGrid.AllowDataRowSelection* became obsolete, use *DxDataGrid.SelectionMode = “DataGridSelectionMode”* instead.
* *DxDataGrid.SelectedDataRow* renamed to *DxDataGrid.SingleSelectedDataRow*.
* *DxDataGrid.SelectedDataRowChanged* renamed to *DxDataGrid.SingleSelectedDataRowChanged*.

# Beta 2

### New Chart Component

We included the following features in the new Blazor Chart component:

* Area, Bar, Line, and Bubble series types
* Dynamic series creation
* Tooltip and legend customization 
* Multiple axes 
* Pivot Grid data visualization

### Added
* Support for .Net Core 3.0 Preview 8
* Data Grid 
  * Enable/disable sorting within the entire grid (API)
  * Control an individual column’s sorting (enable/disable sorting, set up a column sort order and position among sorted columns)
  * Multiple column sorting
  * Cell text alignment
  * Customize command buttons and control their visibility

# Beta 1

### New Scheduler Component

The new Scheduler component supports the following features:

* Three built-in views: Day, Work Week and Week
* Data binding 
* Recurring appointments

### Added

* Support for .Net Core 3.0 Preview 7
* Data Grid 
  * Toggle column visibility
  * Horizontal scrolling
  * Vertical scrolling
* TreeView - Data binding
* Form Layout - Toggle item visibility

### Changed API

* _ComboBoxDataLoadMode.Defaul_ renamed to _ComboBoxDataLoadMode.Default_.
* Pivot Grid-related enumerations moved from the _DevExpress.Blazor.PivotGrid_ namespace to the _DevExpress.Blazor_ namespace.
* The _SortOrder_ enumeration renamed to _PivotGridSortOrder_, and its members (_Asc_ and _Desc_) renamed to _Ascending_ and _Descending_, respectively.

## [0.0.12] 

### Added
* Data Grid - Virtual scroll
* ComboBox - Virtual scroll

### Changed API

* Data Grid
  * _AllowRowSelection_ renamed to _AllowDataRowSelection_
  * _SelectedDataItem_ renamed to _SelectedDataRow_
  * _SelectedItemChanged_ renamed to _SelectedDataRowChanged_
* TreeView
  * _ExpandedChanging_ divided into two events: _BeforeCollapse_ and _BeforeExpand_
  * _ExpandedChanged_ divided into two events: _AfterCollapse_ and _AfterExpand_
  
## [0.0.11] 

### Added

* TreeView
* ComboBox
  * Filter data
  * Allow user input
  * Keyboard support

## [0.0.10]

### Added
- .Net Core 3.0 Preview 6 support

## [0.0.9]

### Fixed:

* Data Grid
  * A row cannot be selected on iOS.
  * The NullReferenceException occurs when a user edits a new row with a null row editor value.
* ComboBox - A drop-down item cannot be selected on iOS.
* Form Layout - The NullReferenceException occurs when the component is bound to a Model with null property values.

## [0.0.8]

### Added:

Data Grid
*	Cascading combo boxes in the cell's Edit Template
*	Edit Form with custom templates
*	Edit Form validation

### Fixed:

* [DxDataGrid - The NullReferenceException occurs after you cancel new row editing](https://www.devexpress.com/Support/Center/Question/Details/T745260/).

## [0.0.7]

### Added
- Support for Blazor Validation in the Form Layout component and date editors
- Support for NullText in the ComboBox component
- Theme switcher for demos

## [0.0.6]

### Fixed
- Fix Blazor (client-side) support

## [0.0.5] 

### Added
- .Net Core 3.0 Preview 5 support

## [0.0.4]

### Added
- New Form Layout Component.
- New Tabs Component.
- Use a new Form Layout component as the Data Grid's edit form.
- .Net Core 3.0 Preview 4 support.
- Follow Microsoft's renaming from "Razor Components" to "Blazor".

## [0.0.3]

### Added
- Update DevExtreme.AspNet.Data to version 2.2.0 to improve the overall performance.
- Add the Bootstrap hover and select effects to the ComboBox' drop-down list items.
 
### Fixed
- The down arrow image is not properly aligned within the ComboBox' drop-down button.
- Arrow images within the Date Edit calendar's month/year navigation buttons do not have the same height.

## [0.0.2]

### Fixed
- A New command button does not always work properly in the Data Grid.

## [0.0.1]
Initial version contains:
- Data Grid
- Pivot Grid
- Data Editors (ComboBox, Date Edit, Spin Edit, Text Box)
- Pager 
