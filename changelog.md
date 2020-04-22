# NuGet Package Change Log

Version history of the "DevExpress.Blazor" NuGet package is listed below.

# 19.2.5-Preview

### .NET Core 3.1.3 and Blazor WebAssembly 3.2.0 Preview 4 Support

In this version, we added support for the [.NET Core 3.1.3](https://github.com/dotnet/core/blob/master/release-notes/3.1/3.1.3/3.1.3.md) and [Blazor Web Assembly 3.2.0 Preview 4](https://devblogs.microsoft.com/aspnet/blazor-webassembly-3-2-0-preview-4-release-now-available/) updates.

### New Toolbar Component
Our new Toolbar component for Blazor includes the following features:
* Various button types 
  * Drop-down items
  * Checked/unchecked items 
  * Radio groups
  * Link items
* Button render and style customization
* Adaptive mode

### New Context Menu Component
Our new Context Menu component for Blazor includes the following features:
* Data binding
* Unbound mode
* Item groups
* Item appearance customization

### Data Grid Enhancements
* Column chooser
* Header template

### Charts Enhancements
* Axis data type customization
* Handle a series' visibility changes

### Data Editors Enhancements
* Display format
* CheckBox - Alignment
* Spin Edit
  * Touch device usability enhancements
  * Custom increment values
  * Update the value on input change
  * Support for HTML attributes
* Text Box 
  * Update the value on input change
  * Support for HTML attributes
* ComboBox, Date Edit, TagBox - Support for HTML attributes

### Resolved Issues
Refer to [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=19.2.5&endBuildName=19.2.4&buildsMode=Single&hasPlatformsWithProducts=true
) for a complete list of issues that were resolved in 19.2.5-Preview.

### Breaking Changes
* [Data Grid - Format-related properties of the Spin Edit and Date Edit columns have been renamed](https://supportcenter.devexpress.com/ticket/details/T874276)
* TreeView 
  * [Click on a node's expand/collapse button no longer invokes an action associated with a click on the node itself](https://supportcenter.devexpress.com/ticket/details/t875624)
  * [The TreeViewNodeInfo class has been moved to an internal namespace](https://supportcenter.devexpress.com/ticket/details/T878784)
* [Date Edit - The default date format is now culture-dependent](https://supportcenter.devexpress.com/ticket/details/T874294)

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

* Chart – Rotation ([Demo](https://demos.devexpress.com/blazor/ChartAxes#ChartRotation) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxChartBase-1.Rotated))
* Calendar - Navigation through months, years, decades, and centuries ([Demo](https://demos.devexpress.com/blazor/Calendar) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar#select-dates))

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
