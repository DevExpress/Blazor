# NuGet Package Change Log

Version history of the "DevExpress.Blazor" NuGet package is listed below.

# 21.1.5

### Grid

#### Filter Row

Our Blazor Grid now includes a filter row that displays in-place text editors for all data columns. The Grid creates a filter condition based on the editor value and applies this condition to the corresponding column. To display the filter row, set the [ShowFilterRow](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowFilterRow) property to true.

We also implemented the following filter row customization options: 

* [FilterRowOperatorType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowOperatorType) – Specifies the operator used to create a filter condition based on the filter row value (Equals, Contains, StartsWith, Greater, Less, and so on).  
* [FilterRowValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowValue) - Specifies the initial value in the filter row editor.  
* [FilterRowEditorVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowEditorVisible) – Specifies whether to display the filter row editor. 
* [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.FilterRowCellTemplate) - Allows you to display a custom editor in a filter row cell.

[Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowFilterRow) | [Demo](https://demos.devexpress.com/blazor/Grid/Filtering) 

#### Filter in Code

You can also manage filter options in code. Call the [FilterBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FilterBy(System.String-DevExpress.Blazor.GridFilterRowOperatorType-System.Object)) method to filter Grid data and the [ClearFilter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ClearFilter) method to reset the applied filter. 

#### Command Column

The new command column type is introduced. This column contains a **Clear** button that resets the applied filter. To display the command column, declare a [DxGridCommandColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn) object in the [Columns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.Columns) template. 
 
You can also define a [FilterRowCellTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridCommandColumn.FilterRowCellTemplate) to display custom content in the column’s filter row cell.
 
[Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ShowFilterRow#command-column) | [Demo](https://demos.devexpress.com/blazor/Grid/Filtering) 

#### API Changes 

The Grid component now includes two types of columns: data and command. To avoid confusion with column names, we made the following changes to the API: 

* You should now use the [DxGridDataColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn) class instead of the [DxGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn) class to add a data column to the Grid. 
* We made the [DxGridColumn](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn) class abstract and it now contains the base API for data and command columns. 

We also renamed the following templates: 

* ColumnGroupRowTemplate => [DataColumnGroupRowTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataColumnGroupRowTemplate) 
* ColumnCellDisplayTemplate => [DataColumnCellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.DataColumnCellDisplayTemplate) 

#### Group Footer Summary

You can now display group summary values in group footers. To do this, set the summary item’s [FooterColumnName](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridSummaryItem.FooterColumnName) property to the name of a group footer column. 

[Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupFooterDisplayMode) | [Demo](https://demos.devexpress.com/blazor/Grid/Summary#GroupFooter) 

#### Group Footer Templates

The new [DxGridColumn.GroupFooterTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.GroupFooterTemplate) and [DxGrid.ColumnGroupFooterTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ColumnGroupFooterTemplate) properties allow you to customize individual or all group footers. 

#### Group Footer Display Mode

The Grid shows group footers if they contain summary values or custom template content and the corresponding groups are expanded.  
 
You can use the new [GroupFooterDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupFooterDisplayMode) property to change the display mode of group footers to **Always**, **Never**, or **IfExpanded**.
 
We also renamed the **ShowFooter** option to [FooterDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.FooterDisplayMode) to make it consistent with [GroupFooterDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GroupFooterDisplayMode). The **FooterDisplayMode** property specifies the visibility of the total footer.  

#### Column Name

We introduced the [Name](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridColumn.Name) property to all Grid columns. Use this property to specify the column’s unique identifier. 

### Chart

#### Refresh Chart Data and Rerender the Component in Code

In v21.1.5, we introduced two new methods to the Chart component:

* [RefreshData](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.RefreshData) - Reloads chart data and redraws the component.
* [RedrawAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.RedrawAsync) - Re-renders the Chart and its child components.

### ComboBox

#### Validate Text

Value and display text can differ in a ComboBox component. You can use the new [ValidateBy](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.ValidateBy) property to specify which component’s property ([Value](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Value) or [Text](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.Text)) is used for input validation.

### Form Layout

#### Group Header Customization

You can now specify a template for a group header. To do this, define the [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.HeaderTemplate) component within the group’s markup, add the render fragment to the template, and wrap group items in the [Items](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.Items) component.

To apply CSS classes to a group header, use the new [HeaderCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.HeaderCssClass) property.

#### Group Appearance Customization

To apply a CSS class to the entire group, use the new [CssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutGroup.CssClass) property.

### Popup

#### Initialization State

The Popup cannot be shown until the component is initialized. To track the initialization state from code, use the [IsInitialized](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.IsInitialized) property. For example, you can check this property value before you call the [ShowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.ShowAsync(System.Threading.CancellationToken)) method.

### Button

#### Navigate URL

Use the new [NavigateUrl](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxButton.NavigateUrl) property to specify the URL the client web browser navigates to when you click the button.

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=21.1.5&endBuildName=21.1.3&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v21.1.5.

# 21.1.4

### Navigation and Layout

#### Menu - Data Binding

You can now bind the Menu component to a data source. In this mode, items from the data source automatically populate menu items. To do this, use the component’s [Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.Data) and [DataMappings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu.DataMappings) properties.

[Demo](https://demos.devexpress.com/blazor/Menu#DataBinding) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu#data-binding) 

#### Context Menu, TreeView - Binding to Flat Data

You can now bind the Context Menu and TreeView components to flat data (a collection of items that are available at one level). Use the following properties to enable this feature:
* Context Menu - [DxContextMenu.Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.Data) and [DxContextMenu.DataMappings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu.DataMappings) 
  
  [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxContextMenu#bound-mode)
* TreeView - [DxTreeView.Data](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.Data) and [DxTreeView.DataMappings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView.DataMappings) 
  
  [Demo](https://demos.devexpress.com/blazor/TreeView#MasterDetailDataBinding) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeView#flat-data)

#### Popup - Close Reason

The [DxPopup.Closing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Closing) event’s arguments now include a new property - [CloseReason](https://docs.devexpress.com/Blazor/DevExpress.Blazor.PopupClosingEventArgs.CloseReason). This property identifies an action that closes the Popup. The available actions are: 
* Programmatically 
* EscapePress 
* CloseButtonClick
* OutsideClick 

#### Form Layout

##### Disabled and Read-Only Modes at Various Component Levels

You can now activate disabled/read-only mode for all auto-generated editors at the following Form Layout levels:
* An entire component
* A layout group, tab, or tab page
* A layout item

The Form Layout and its elements apply values of the corresponding properties ([Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout.Enabled) and [ReadOnly](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayout.ReadOnly)) to nested elements. If you specify the corresponding property for a nested element, this value overrides the common value.

##### Omit the Template Tag for Form Layout Items

When you specify a [template](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxFormLayoutItem.Template) for a Form Layout item, you can now omit the `<Template>...</Template>` tag and specify the template’s content in the item’s markup. This improves the readability of the page layout code.

### Data Editors

#### CheckBox

##### Allow/Restrict Indeterminate State

Use the new [AllowIndeterminateState](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1.AllowIndeterminateState) property to specify whether the CheckBox component supports the indeterminate state.
##### Wrap Mode for Long Labels

If the CheckBox label is too long to fit the parent component, use the new [LabelWrapMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCheckBox-1.LabelWrapMode) property to specify whether the label’s text should be wrapped or cropped.

### Charts

#### The Maximum Number of Automatic Scale Breaks

The new [MaxAutoBreakCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartValueAxis.MaxAutoBreakCount) property allows you to limit the number of auto-created scale breaks.

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=21.1.4&endBuildName=21.1.3&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v21.1.4.

### Breaking Changes

* [T1001744](https://supportcenter.devexpress.com/ticket/details/t1001744/treeview-contextmenu-some-api-members-related-to-data-binding-are-now-obsolete-a-newme-api-members-related-to-data-binding-have-become-obsolete-a-new): TreeView, ContextMenu - Some API members related to data binding are now obsolete. A new data binding approach was introduced
* [T1007681](https://supportcenter.devexpress.com/ticket/details/t1007681/scheduler-crud-events-changed-their-delegate-type-from-action-to-eventcallback): Scheduler - CRUD events changed their delegate type from Action to EventCallback
* [T1003629](https://supportcenter.devexpress.com/ticket/details/t1003629/charts-the-dxchartvaluebreaks-class-is-now-obsolete): The DxChartValueBreaks class is now obsolete

# 21.1.3

### New Grid (CTP)

Our new Blazor Grid component includes the following features:

* Data Binding
* Custom Data Source Support
* Large Datasets
* Unbound Columns
* Sorting by Value
* Sorting by Display Text
* Custom Sorting
* Grouping
* Group Intervals
* Custom Grouping
* Paging
* Total and Group Summary
* Custom Summary
* Cell, Column Header, Group Row, and Footer Templates
* Custom Display Text

[Demo](https://demos.devexpress.com/blazor/Grid/DataBinding)

### New Rich Text Editor (CTP)

Our new Blazor Rich Text Editor (Word Processor) allows you to quickly incorporate advanced text editing functionality into your next Blazor app. You can create, open, edit, convert, save, and print rich-formatted text files (DOCX, RTF, TXT). Its features include:

* Ribbon UI
* Print Layout / Simple View
* Horizontal Ruler
* Character & Paragraph Formatting
* Bullets & Numbering
* Header & Footer
* Document Sections
* Table of Contents
* Bookmarks & Links
* Page Numbers
* Fields
* Pictures & Text Inputs
* Undo / Redo

[Demo](https://demos.devexpress.com/blazor/RichEdit) | [Documentation](https://docs.devexpress.com/Blazor/401891/rich-text-editor) | [Get Started](https://docs.devexpress.com/Blazor/403121/rich-edit/get-started-with-rich-text-editor)

### New Masked Input

Our new Blazor Masked Input component includes the following integrated features:

* Text, Numeric, Date-Time, and Regular Expression Mask support
* Read-only and Disabled States
* Null Text
* Clear Button

[Demo](https://demos.devexpress.com/blazor/MaskedInput) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMaskedInput-1)

### New Report Viewer

v21.1 ships with the first-ever native Blazor Report Viewer component. The new component targets the Blazor Server platform and features the following built-in features/capabilities:

* C# Public API
* Print / Export
* Toolbar UI
* Bootstrap Theme support
* Parameters Panel
* Drill-Down support
* Interactive Sorting
* Zoom support

[Get Started](https://docs.devexpress.com/XtraReports/403069)

### New Project Wizard

v21.1 ships with a new Blazor Project Wizard. This wizard allows you to choose a theme and specify localization settings for your Blazor application.

### Bootstrap 5 Support

DevExpress Blazor UI components now support Bootstrap 5. Set the global [BootstrapVersion](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Configuration.GlobalOptions.BootstrapVersion) option to `v5` and follow the [migration guide](https://getbootstrap.com/docs/5.0/migration/) to get started.

### Migration to .NET 5.0

DevExpress Blazor UI components now support .NET 5.0 (exclusively). All Project Templates in the DevExpress Template Gallery have been updated to reflect this change.

### Charts

#### Pan and Zoom

Users can now zoom and pan the chart area with the mouse wheel or touch gestures. To enable this feature, add the [DxChartZoomAndPanSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings) component to the Chart's markup and specify its [ArgumentAxisZoomAndPanMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.ArgumentAxisZoomAndPanMode) and [ValueAxisZoomAndPanMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings.ValueAxisZoomAndPanMode) properties.

[Demo](https://demos.devexpress.com/blazor/ZoomAndPan) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartZoomAndPanSettings)

#### Axis Label Format
The new [ChartElementFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartElementFormat) class defines format settings for axis labels. You can specify various numeric and date-time formats along with format specific settings like precision. You can also use the [FromLdmlString](https://docs.devexpress.com/Blazor/DevExpress.Blazor.ChartElementFormat.FromLdmlString(System.String)) method to create the desired custom format.

#### Add/Remove Extra Margins to Outermost Series Points

The new [EndOnTick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.EndOnTick) option determines whether Chart axes begin and end on ticks. The [SideMarginsEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxis-1.SideMarginsEnabled) option adds extra margin space between outermost series points and chart boundaries.

#### Custom Chart Size

Use the [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.Width) and [Height](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1.Height) properties to specify the Chart's size.

#### Disable Chart Animation
To disable chart animation, add the [DxChartAnimationSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnimationSettings) component into the Chart's markup and disable the [Enabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAnimationSettings.Enabled) option.

#### Data Aggregation

The DevExpress Blazor Chart component now offers data aggregation support. Data aggregation significantly improves rendering performance (when rendering a chart against an extremely large set of data points). Aggregation methods include: Auto, Average, Count, Financial, Max, Min, Range, and Sum.

[Demo](https://demos.devexpress.com/blazor/ZoomAndPan) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChart-1#data-aggregation)

### Data Editors

#### Input Masks

DevExpress Blazor data input UI components allow you to apply input masks with ease. Masks define data entry constraints and help ensure data consistency and information integrity.

Our Blazor data input UI components support the following mask types:

* Date-Time 
* Numeric (e.g. currency, percentage, etc.) 

[Demo - Date-Time Masks](https://demos.devexpress.com/blazor/DateEdit#Mask) | [Demo - Numeric Masks](https://demos.devexpress.com/blazor/SpinEdit#Mask) | [Documentation](https://docs.devexpress.com/Blazor/402513/data-editors/masks)

#### Move Focus to an Editor in Code

Our Blazor Data Editors include a new `FocusAsync` method that allows you to focus the input field in code.

### Navigation and Layout

#### Popup - Header, Body, and Footer Customization

Our Blazor Popup API now offers extended customization options for the following UI elements:

* [HeaderText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.HeaderText)
* [BodyText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.BodyText)
* [FooterText](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.FooterText)
* [HeaderContentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.HeaderContentTemplate)
* [BodyContentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.BodyContentTemplate)
* [FooterContentTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.FooterContentTemplate)
* [HeaderTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.HeaderTemplate)
* [BodyTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.BodyTemplate)
* [FooterTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.FooterTemplate)
* [ShowHeader](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.ShowHeader)
* [ShowFooter](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.ShowFooter)

[Demo](https://demos.devexpress.com/blazor/Popup#Customization)

#### Popup Size

Our new [MinHeight](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.MinHeight), [MaxHeight](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.MaxHeight), [MinWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.MinWidth), and [MaxWidth](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.MaxWidth) properties allow you to explicitly define a popup's size constraints whenever a popup adapts itself to content.

You can also use the [Height](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Height) and [Width](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Width) properties to manually specify Popup size.

 [Demo](https://demos.devexpress.com/blazor/Popup#Alignment)
 
 #### Popup Position

Use our new [HorizontalAlignment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.HorizontalAlignment) and [VerticalAlignment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.VerticalAlignment) properties to position a Popup on screen. ([Demo](https://demos.devexpress.com/blazor/Popup#Alignment))

#### Show Multiple Popups

You can now display multiple Popups simultaneously. Popup Z-indices are updated automatically (based on display order). This release also includes a new [ZIndex](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.ZIndex) property. You can use this new property to specify a popup's Z-index manually. ([Demo](https://demos.devexpress.com/blazor/Popup#Events))

#### Popup - Show and Close Actions

In addition to the Close button, you can now press Escape or click outside the Popup's boundaries to close a Popup. This release includes two customization options - [CloseOnEscape](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.CloseOnEscape) and [CloseOnOutsideClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.CloseOnOutsideClick). These options can be used to disable this functionality.

Our new [ShowAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.ShowAsync(System.Threading.CancellationToken)) and [CloseAsync](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.CloseAsync(System.Threading.CancellationToken)) methods allow you to asynchronously display and hide a Popup in code.

We've also implemented the following new events:

* [Showing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Showing) - Fires before the Popup is displayed and allows you to cancel this action.
* [Shown](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Shown) - Fires after the Popup is displayed.
* [Closing](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Closing) - Fires before the Popup is closed and allows you to cancel this action.
* [Closed](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxPopup.Closed) - Fires after the Popup is closed.

[Demo](https://demos.devexpress.com/blazor/Popup#Events)

#### Tabs - Tab Content Render Modes

Use the new [DxTabs.RenderMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTabs.RenderMode) property to specify how the DevExpress Blazor Tab component loads tab content. Render modes are as follows:

* Default. Adds tab content to the DOM each time a tab is activated (replaces the content of the previously active tab).
* All Tabs. Renders all tab content on initial load and persists it within the DOM. This mode should only be used for apps with a few tabs in its layout (as it can increase page load time).
* On Demand. Renders tab content when a tab is activated and persists it in the DOM.

#### API Enhancements

* [DxToolbar.TitleTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxToolbar.TitleTemplate) - Used to define the template for a toolbar's caption/title.
* [DxTabs.TabClick](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTabs.TabClick) / [DxTabBase.Click](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxTabBase.Click) - Used to specify the click event handler for all/individual tabs.

### Scheduler

#### New Month View

Our Blazor Scheduler ships with a new Month View option. The Month View includes a [MonthCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView.MonthCount) property. 

[Demo](https://demos.devexpress.com/blazor/SchedulerViewTypes#MonthView) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerMonthView)

#### New Timeline View

Our new Blazor Timeline View arranges events and appointments across an easy-to-read horizontal timeline. Thanks to its flexible design, our Timeline View allows you to display multiple time rulers with different scales. 

[Demo](https://demos.devexpress.com/blazor/SchedulerViewTypes#TimelineView) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerTimelineView)

#### Appointment Tooltip Customization

You can now customize appointment/event tooltips as needed. Use the new [AppointmentTooltipTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentTooltipTemplate) property to specify custom layouts and custom appearance settings for your tooltip. ([Demo](https://demos.devexpress.com/blazor/SchedulerCustomization#CustomAppointmentTooltip))

#### Restrict User Actions

The following new options allow you to configure/control Scheduler-related actions available to end users:

* [AllowCreateAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AllowCreateAppointment)
* [AllowEditAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AllowEditAppointment)
* [AllowDeleteAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AllowDeleteAppointment)

[Demo](https://demos.devexpress.com/blazor/SchedulerCustomization#RestrictUserActions)

#### API Enhancements
* [StartDate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.StartDate) and [ActiveViewType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ActiveViewType) properties now support two-way binding to a data field.
* [StartDateChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.StartDateChanged) / [ActiveViewTypeChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ActiveViewTypeChanged) - Allow you to track changes to `StartDate` and `ActiveViewType`properties.
* [AppointmentFormMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentFormMode) - Specifies the form used to create and edit appointments/events: compact, popup, or both.
* [ShowAppointmentTooltip](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.ShowAppointmentTooltip) - Specifies whether to display a tooltip when a user clicks an appointment/event.
* [SelectedAppointment](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.SelectedAppointment) - Gets the selected appointment.
* [SelectedAppointmentChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.SelectedAppointmentChanged) - Allows you to track changes to the `SelectedAppointment`property.

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.2.8&endBuildName=21.1.3&buildsMode=Range&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.1.3.

### Breaking Changes

* [T982678](https://supportcenter.devexpress.com/ticket/details/T982678/devexpress-blazor-components-no-longer-support-net-core-3-1): DevExpress Blazor components no longer support .NET Core 3.1
* [T999135](https://supportcenter.devexpress.com/ticket/details/T999135/data-grid-localization-strings-have-changed-their-prefix-from-grid-to-datagrid-): Data Grid - Localization strings have changed their prefix from `Grid_` to `DataGrid_`
* [T999158](https://supportcenter.devexpress.com/ticket/details/T999158/changed-alignment-of-data-editors-in-css-containers-): Data Editors - Changed alignment of data editors in CSS containers
* [T986360](https://supportcenter.devexpress.com/ticket/details/T986360/charts-the-dxchartcommonseries-aggregationmethod-and-dxchartseries-aggregationmethod): Charts - The `DxChartCommonSeries.AggregationMethod` and `DxChartSeries.AggregationMethod` properties have become obsolete
* Scheduler
	* [T990675](https://supportcenter.devexpress.com/ticket/details/T990675/scheduler-behavior-of-appointment-edit-forms-has-changed): Behavior of appointment edit forms has changed
	* [T990618](https://supportcenter.devexpress.com/ticket/details/T990618/scheduler-horizontal-appointments-now-display-their-status-): Horizontal appointments now display their status
	* [T990650](https://supportcenter.devexpress.com/ticket/details/T990650/scheduler-the-rendering-of-horizontal-appointments-was-changed): The rendering of horizontal appointments was changed
* Popup
	* [T986662](https://supportcenter.devexpress.com/ticket/details/T986662/popup-the-popup-has-changed-its-rendering): The Popup has changed its rendering
	* [T986363](https://supportcenter.devexpress.com/ticket/details/T986363/popup-the-closebuttonclick-event-has-become-obsolete): The `CloseButtonClick` event has become obsolete
	* [T972514](https://supportcenter.devexpress.com/ticket/details/T972514/popup-the-content-property-has-become-obsolete): The `Content` property has become obsolete
	* [T972521](https://supportcenter.devexpress.com/ticket/details/T972521/popup-the-footertemplate-property-has-changed-its-behavior-and-signature-): The `FooterTemplate` property has changed its behavior and signature
	* [T972518](https://supportcenter.devexpress.com/ticket/details/T972518/popup-the-headertemplate-property-has-changed-its-signature): The HeaderTemplate property has changed its signature
	* [T985590](https://supportcenter.devexpress.com/ticket/details/T985590/popup-the-visible-property-has-changed-its-default-value): The `Visible` property has changed its default value
	* [T986380](https://supportcenter.devexpress.com/ticket/details/T986380/popup-the-popup-has-changed-its-default-position-on-the-screen): The Popup has changed its default position on the screen
* [T975366](https://supportcenter.devexpress.com/ticket/details/T975366/context-menu-renamed-api-members): Context Menu - Renamed API members
* [T975628](https://supportcenter.devexpress.com/ticket/details/T975628/the-menuitemsposition-enum-has-been-replaced-with-the-itemposition-enum): The `MenuItemsPosition` enum has been replaced with the `ItemPosition` enum
* [T980276](https://supportcenter.devexpress.com/ticket/details/T980276/treeview-the-dxtreeviewnode-navigateurl-property-set-to-a-non-empty-url-no-longer-has-an): TreeView - The `DxTreeViewNode.NavigateUrl` property set to a non-empty URL no longer has an effect.
* [T999452](https://supportcenter.devexpress.com/ticket/details/T999452/dxtabs-the-markup-of-the-tab-content-area-has-been-changed): DxTabs - The markup of the tab content area has been changed
* [T995722](https://supportcenter.devexpress.com/ticket/details/T995722/form-layout-changed-the-default-approach-used-to-calculate-caption-paddings): Form Layout - Changed the default approach used to calculate caption paddings

# 20.2.6

### Data Grid

Drop-down width modes for Combobox columns: 

* Content or editor width
* Content width
* Editor width

[Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGridComboBoxColumn-1.DropDownWidthMode)

### Data Editors

#### HTML events 

Data editors based on the standard HTML input element now apply popular event handlers to the input element directly. For a complete list of data editors and supported event handlers, refer to the following help topic: [HTML Attributes and Events](https://docs.devexpress.com/Blazor/401918/common-concepts/html-attributes-and-events).

#### Spin Edit
 
You can now use the mouse wheel to change an editor’s value.

### Chart Enhancements

The new [DxChartToooltip.Position](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartTooltip.Position) property specifies whether the component displays tooltips inside or outside the series.

### Scheduler Enhancements

Use the new [DxSchedulerDataStorage.RecurrenceSettings](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxSchedulerDataStorage.RecurrenceSettings) property to define common settings for all recurrent appointments displayed in the Scheduler.

### CodeRush

[CodeRush](https://www.devexpress.com/products/coderush/) now includes templates that allow you to quickly create popular DevExpress components for Blazor in Visual Studio. For more information, refer to the following help topic: [Templates for DevExpress Components](https://docs.devexpress.com/CodeRushForRoslyn/402947/coding-assistance/code-templates/templates-for-blazor/templates-for-devexpress-components).

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.2.6&endBuildName=null&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.2.6.

### Breaking Change

[T971305](https://supportcenter.devexpress.com/ticket/details/t971305/charts-the-dxcharttooltip-enabled-property-should-be-set-to-true-to-display-tooltips) - Charts - The DxChartTooltip.Enabled property should be set to true to display tooltips with templates.

# 20.2.5

### New Menu Component
Our new Menu component for Blazor includes the following features:

* Horizontal/vertical orientation 
* Display modes (Auto, Desktop, and Mobile)
* Adaptive layout
* Templates for menu items, item text, and item submenu

[Demo](https://demos.devexpress.com/blazor/menu) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMenu)

### Chart Enhancements
Grid lines visibility. To add vertical grid lines or hide both vertical and horizontal grid lines to/from the Chart component, use the axis’s [Visible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxChartAxisGridLines.Visible) property.

### Scheduler Enhancements
Handle the new [StartDateChanged](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.StartDateChanged) event to synchronize the range of visible dates in the Scheduler with external components or labels.

### Resolved Issues
See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.2.5&endBuildName=null&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.2.5.

### Breaking Change
[T958401](https://supportcenter.devexpress.com/ticket/details/t958401/popup-the-closebuttonclick-event-changed-the-delegate-type-from-action-to-eventcallback) - Popup - The CloseButtonClick event changed the delegate type from Action to EventCallback

# 20.2.4 

### Grid Layout 
#### Named Areas for Responsive Layouts 
You can now create named areas, assign them to layout items, and place these areas in grid rows to create responsive layouts. ([Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridLayout#use-named-areas) | [Demo](https://demos.devexpress.com/blazor/GridLayout#Areas)) 

### Data Editors 
#### Input CSS Classes 
The new [InputCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxComboBox-2.InputCssClass) property allows you to apply predefined or custom CSS classes to the input element of the ComboBox, Date Edit, Spin Edit, Text Box, and Time Edit.  

#### Memo – Text Area CSS Class 
The new [TextAreaCssClass](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo.TextAreaCssClass) property allows you to apply a predefined or custom CSS class to the Memo’s text area. 

#### Date Edit and Calendar – First Week of the Year 
Use the [WeekNumberRule](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxCalendar-1.WeekNumberRule) property to specify the first week of the year in the calendar. 

### Upload 

#### Authentication and Cancel Upload 
Handle the new [FileUploadStart](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxUpload.FileUploadStart) event to add authentication information to upload requests, cancel an upload based on a condition or change the upload URL. 

### Blazor Project Templates  

#### .NET 5.0 Support 

The DevExpress Template Gallery now allows you to create a Blazor application that targets .NET 5.0. 


### Resolved Issues 
See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.2.4&endBuildName=null&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.2.4. 


# 20.2.3

### Support for .NET 5.0

In this version, we added support for [.NET 5.0 Release Candidate 2](https://devblogs.microsoft.com/dotnet/announcing-net-5-0-rc-2/).

### Blazor Components in the DevExpress Installer

You can now use the DevExpress .NET Product Installer to install DevExpress Blazor components.([Documentation](https://docs.devexpress.com/Blazor/401057/getting-started/install-components-and-create-an-application))

### Visual Studio Integration

#### Blazor Project Templates

The DevExpress Template Gallery now includes Blazor project templates. ([Documentation](https://docs.devexpress.com/Blazor/401057#devexpress-templates))

### New Grid Layout

The new Grid Layout for Blazor allows you to arrange UI elements on a page. The component is based on a CSS Grid Layout: layout items are organized into rows and columns. 

[Demo](https://demos.devexpress.com/blazor/GridLayout) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridLayout)

### New Stack Layout

The new Stack Layout for Blazor allows you to stack UI elements vertically or horizontally. 

[Demo](https://demos.devexpress.com/blazor/StackLayout) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxStackLayout)

### New Layout Breakpoint

The new Layout Breakpoint component for Blazor allows you to adapt a page layout to different screen sizes. 
For example, you can use breakpoints to create responsive DxGridLayout, DxStackLayout, or any other components.

[Demo](https://demos.devexpress.com/blazor/GridLayout#Adaptivity) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxLayoutBreakpoint)

### New Time Editor

The new Time Edit component for Blazor has the following features:

* DateTime / TimeSpan binding
* Integrated drop-down Time Picker
* 12 / 24 Hour Format support
* Min / Max Time support
* Read-Only and Disabled States
* Null Text
* Clear Button

[Demo](https://demos.devexpress.com/blazor/TimeEdit) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTimeEdit-1)

### Data Grid Enhancements

#### Total and Group Summaries

The Data Grid can now compute summaries across all data rows or individual groups. Predefined aggregate functions include:

* Sum
* Min
* Max
* Avg
* Count

[Demo](https://demos.devexpress.com/blazor/GridSummary) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1#summary)

#### Column Resize

Users can now resize grid columns. To enable this feature, use the [ColumnResizeMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.ColumnResizeMode) property.

[Demo](https://demos.devexpress.com/blazor/GridResizeColumns) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1#resize-columns)

#### Fixed Columns

You can now use the new [FixedStyle](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataGridColumnBase-1.FixedStyle) property to anchor columns to the left or rightmost edge of the grid. These fixed columns are never scrolled horizontally.

[Demo](https://demos.devexpress.com/blazor/GridPagingAndScrolling#FixedColumns) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.Base.DxDataGridColumnBase-1.FixedStyle)

### Scheduler

#### Custom Appointment Form

Our new [AppointmentFormLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentFormLayout) and [AppointmentCompactFormLayout](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.AppointmentCompactFormLayout) properties allow you to create a custom appointment form.

[Demo](https://demos.devexpress.com/blazor/SchedulerCustomization#CustomAppointmentForm) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler#custom-appointment-form) 
 
#### Resources

With this release, you can associate Scheduler appointments with resources (such as employees, locations, and so on). 
Then, you can use the new [GroupType](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler.GroupType) property to group appointments by resources or dates. 
The Scheduler also ships with a Resource Navigator that allows you to filter resource groups.

[Demo](https://demos.devexpress.com/blazor/SchedulerResources) | [Documentation](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxScheduler#resources)
 
### Data Editors

#### Date Edit - Display Time

The new [TimeSectionVisible](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.TimeSectionVisible) property allows you to display time values in the Date Edit component.

#### Long Mouse Click / Long Key Press Support

Users can now long click or long key press to modify the Spin Edit value. In the ComboBox and TagBox components, users can use a long key press to navigate through items.

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.2.3&endBuildName=&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.2.

### Breaking Changes

* [Scheduler - Renamed API members](https://supportcenter.devexpress.com/ticket/details/t939823)
* [Reporting for Blazor - Renamed API members](https://supportcenter.devexpress.com/ticket/details/T934943)

# 20.1.11

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.11&endBuildName=null&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.1.11.

# 20.1.10

### Resolved Issues

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.10&endBuildName=null&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.1.10.

# 20.1.9

### Resolved Issue

In this version, we resolved the following issue:
 
* [T951686](https://supportcenter.devexpress.com/ticket/details/t951686) - .NET 5.0: The "Microsoft.WebTools.Shared.Exceptions.WebToolsException: Build failed." error occurs while publishing a project with v20.1.8

# 20.1.8

### Support for .NET 5.0
 
In this version, we added support for [.NET 5.0](https://devblogs.microsoft.com/dotnet/announcing-net-5-0/). 

### Resolved Issues 

See our [Version History](https://supportcenter.devexpress.com/versionhistory?platformsWithProducts=3c616c71-03dc-46b9-a54f-1334a22dffe7&entries=ResolvedIssues&startBuildName=20.1.8&endBuildName=null&buildsMode=Single&hasPlatformsWithProducts=true) for a complete list of issues resolved in v20.1.8.

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

[Demo](https://demos.devexpress.com/blazor/Memo) | [Documentation]( https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxMemo)

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
