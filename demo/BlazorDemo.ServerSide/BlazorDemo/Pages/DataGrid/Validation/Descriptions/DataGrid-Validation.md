This demo illustrates how to use the [Data Grid](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1)'s [EditFormTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxDataGrid-1.EditFormTemplate) with Blazor's standard [EditForm](https://docs.microsoft.com/aspnet/core/blazor/forms-validation?view=aspnetcore-3.0) component to create a custom edit form with validation.

The **EditForm** validates input values when they are changed and when a user clicks the **Update button** to submit this form. Editors become marked with colored outlines: red indicates invalid values and green indicates values that were posted successfully.

In this demo, all form fields except for **Title of Courtesy** are marked as required. The **Birth Date** and **Hire Date** field values should be within the specified ranges. The **Notes** field value should have a length between 4 and 256 characters.
