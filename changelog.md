# NuGet Package Change Log

Version history of the "DevExpress.Blazor" NuGet package is listed below.

# 19.1.8 (latest release)

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
