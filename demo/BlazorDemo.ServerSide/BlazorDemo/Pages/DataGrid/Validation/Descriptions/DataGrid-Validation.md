This demo illustrates how to use the [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1)'s [EditFormTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.EditFormTemplate) with Blazor's standard [EditForm](https://docs.microsoft.com/aspnet/core/blazor/forms-validation?view=aspnetcore-3.0) component to create a custom edit form with validation.

Click **Edit** to show this form. All form fields are marked as required, and the **Vacancy Description** field’s value should have a length between 4 and 32 characters. The **City** and **Region** comboboxes are cascaded.

When you attempt to submit changes, editors are marked with colored outlines. Red indicates invalid values and green indicates values that were posted successfully.
