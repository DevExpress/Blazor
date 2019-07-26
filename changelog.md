# NuGet Package Change Log

Version history of the "DevExpress.Blazor" NuGet package is listed below.

# Beta 1 (latest release)

### New Scheduler Component

The new Scheduler component has the following features:

* Three built-in views: Day, Work Week and Week
* Data binding 
* Recurring appointments

### Added Features

* Support for .Net Core 3.0 Preview 7
* Grid 
  * Column Visibility
  * Column Editor Visibility
  * Horizontal Scrolling
  * Vertical Scrolling
* TreeView - Data Binding
* Form Layout - Items Visibility

### Renamed and Restructured API

* _ComboBoxDataLoadMode.Defaul_ renamed to _ComboBoxDataLoadMode.Default_.
* Pivot Grid-related enumerations moved from the _DevExpress.Blazor.PivotGrid_ namespace to the _DevExpress.Blazor_ namespace.
* The _SortOrder_ enumeration renamed to _PivotGridSortOrder_, and its members (_Asc_ and _Desc_) renamed to _Ascending_ and _Descending_, respectively.

## [0.0.12] 

### Added
* Data Grid - Virtual Scroll
* ComboBox - Virtual Scroll

### Renamed and Restructed API

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
* Combo Box
  * Filter Data
  * Allow User Input
  * Keyboard Support

## [0.0.10]

### Added
- Support for .Net Core 3.0 Preview 6.

## [0.0.9]

### Fixed:

* Data Grid
  * A row cannot be selected on iOS.
  * The NullReferenceException occurs when a user edits a new row with a null row editor value.
* Combo Box - A drop-down item cannot be selected on iOS.
* Form Layout - The NullReferenceException occurs when the component is bound to a Model with null property values.

## [0.0.8]

### Added:

New Data Grid features:
*	Cascading combo boxes in the cell's Edit Template.
*	Edit Form with custom templates.
*	Edit Form validation.

### Fixed:

* [DxDataGrid - The NullReferenceException occurs after you cancel new row editing](https://www.devexpress.com/Support/Center/Question/Details/T745260/).

## [0.0.7]

### Added
- Support for Blazor Validation in the Form Layout component and date editors.
- Support for NullText in the Combo Box component.
- Theme switcher for demos.

## [0.0.6]

### Fixed
- Fix Blazor (client-side) support

## [0.0.5] 

### Added
- Support for .Net Core 3.0 Preview 5.

## [0.0.4]

### Added
- New Form Layout Component.
- New Tabs Component.
- Use a new Form Layout component as the Data Grid's edit form.
- Support for .Net Core 3.0 Preview 4.
- Follow Microsoft's renaming from "Razor Components" to "Blazor".

## [0.0.3]

### Added
- Update DevExtreme.AspNet.Data to version 2.2.0 to improve the overall performance.
- Add the Bootstrap hover and select effects to the Combo Box' drop-down list items.
 
### Fixed
- The down arrow image is not properly aligned within the Combo Box' drop-down button.
- Arrow images within the Date Edit calendar's month/year navigation buttons do not have the same height.

## [0.0.2]

### Fixed
- A New command button does not always work properly in the Data Grid.

## [0.0.1]
Initial version contains:
- Data Grid
- Pivot Grid
- Data Editors (Combo Box, Date Edit, Spin Edit, Text Box)
- Pager 
