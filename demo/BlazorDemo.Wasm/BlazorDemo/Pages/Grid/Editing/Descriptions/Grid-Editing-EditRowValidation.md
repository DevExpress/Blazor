Our Blazor Grid uses the standard [DataAnnotationsValidator](https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation#data-annotations-validator-component-and-custom-validation-1) to validate user input (based on [data annotation attributes](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation) defined in an edit model). Once a user removes focus from data editors or attempts to save an edited row, editors are marked with colored outlines: green indicates valid values, red - invalid values.

When you define the `CellEditTemplate`, you can use any of the following approaches to display validation messages for individual data editors:

* Use the template context's `EditContext` property to access the validation message's text and display it manually.
* Use Blazor's standard [ValidationMessage](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.components.forms.validationmessage-1) component.

You can also implement your custom validator components and declare them in the [CustomValidators](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.CustomValidators) template. To disable input validation, set the [ValidationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.ValidationEnabled) option to `false`.