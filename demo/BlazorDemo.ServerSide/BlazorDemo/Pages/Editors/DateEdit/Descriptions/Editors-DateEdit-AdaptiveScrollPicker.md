Our Blazor [Date Edit](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1) can adapt its data picker (date selector) to each device type. To specify a picker type, use the [PickerDisplayMode](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.PickerDisplayMode) property. The following values are supported:

*   **Auto** (default) - Mobile and tablet devices display the datepicker as a scroll picker. Mobile devices also display a modal window for datepickers. Other device types display the datepicker as a calendar.
*   **Calendar** - All devices display the datepicker as a calendar.
*   **ScrollPicker** - All devices display the datepicker as a scroll picker.

When the datepicker is displayed as a scroll picker (in Auto or ScrollPicker mode), use the [ScrollPickerFormat](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDateEdit-1.ScrollPickerFormat) property to define the date format for each scroll picker segment (day, month, and year). Supported formats are:

*   **ddd** - A day is specified by its date and the short name of the day of the week (for example, _15 Fri_).
*   **dddd** - A day is specified by its date and the full name of the day of the week (for example, _15 Friday_).
*   **dd** or **d** - A day is specified by its date (for example, _15_).
*   **MMM** - A month is specified by its short name (for example, _Oct_).
*   **M**,**MM**,or **MMMM** - A month is specified by its full name (for example, _October_).
*   **y**, **yy**, **yyy**, or **yyyy** - A year is specified by its full number (for example, _2019_).

The order of specified formats defines the order of corresponding scroll picker segments.
