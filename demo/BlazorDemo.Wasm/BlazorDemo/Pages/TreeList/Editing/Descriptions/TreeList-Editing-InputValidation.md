Our Blazor [TreeList](https://docs.devexpress.com/Blazor/404942/components/treelist) uses the standard [DataAnnotationsValidator](https://learn.microsoft.com/en-us/aspnet/core/blazor/forms/validation?view=aspnetcore-7.0#data-annotations-validator-component-and-custom-validation) to validate user input (based on [data annotation attributes](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation) defined in an edit model). The TreeList validates editor values once a user moves focus away from data editors or uses a command that saves changes. In `EditCell` mode, the TreeList control validates user input when focus moves away from the edited row. The control prevents users from editing a different row until they address all validation errors.

You can implement your custom validator components and declare them in the [CustomValidators](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.CustomValidators) template. To disable input validation in our Blazor TreeList component, set the [ValidationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.ValidationEnabled) option to `false`.

DevExpress Blazor data editors implement the following validation settings:
 * [ValidationEnabled](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxEditSettings.ValidationEnabled) — Allows you to disable input validation in the editor.
 * [ShowValidationIcon](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTextEditSettings.ShowValidationIcon) — Specifies whether the editor displays validation icons.
 * [ShowValidationSuccessState](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxEditSettings.ShowValidationSuccessState) — Specifies whether the editor displays green outline and validation icon after successful validation.

This demo validates TreeList data against the following rules:
* The **Task** field is required.
* **Start Date** and **Due Date** values must belong to the 01/01/2017 — 01/01/2027 interval.
* The **Due Date** value cannot be less than the **Start Date** value.

In this demo, you can use checkboxes in the TreeList toolbar to enable/disable validation and display/hide successful validation results. The **Edit Mode** combo box allows you to switch between [edit modes](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxTreeList.EditMode).

**Note**: You should not rely on form validation alone to secure your Blazor-powered app. Form validation is designed to improve application usability. A threat actor can bypass validation and send malicious data to the server. To minimize security related threats/risks, you must track data changes using multiple strategies. Refer to the following topic for additional information: [Validate User Input](https://docs.devexpress.com/Blazor/404263/common-concepts/validate-user-input).
