# DevExpress UI for Razor Components

This demo application is a preview of the DevExpress UI for Razor Components. 

The DevExpress UI components featured in this demo are available for free download and can be used in your next Razor Components/Blazor app.* 

> \* Like any software preview, the DevExpress UI for Razor Components is not without fault. You should not use these products in production environments or in mission-critical applications.

# How to run this demo on your machine

1. Ensure that you have .NET Core 3 installed.
2. Download the "**demo**" directory from this repository.
3. Open **demo/Demo.RazorComponents.sln** in Visual Studio 2019.
4. Start the application.

See also: 

[Introduction to Razor Components](https://docs.microsoft.com/aspnet/core/razor-components/?view=aspnetcore-3.0)

[Get started with Razor Components](https://docs.microsoft.com/ru-ru/aspnet/core/razor-components/get-started?view=aspnetcore-3.0&tabs=visual-studio)

# How to create a new project

Follow the steps below to try our Razor Components in your own application. 

1. Create a new solution using the "Razor Components" or "Blazor" template in Visual Studio 2019.
2. Register the DevExpress Early Access feed in Visual Studio's NuGet Package Manager.

```https://nuget.devexpress.com/early-access/api```

See the [Setup Visual Studio's NuGet Package Manager](https://docs.devexpress.com/GeneralInformation/116698/installation/install-devexpress-controls-using-nuget-packages/setup-visual-studio%27s-nuget-package-manager) topic for more information.

3. Obtain the client runtime from this GitHub repository - download all files from the "client-runtime" directory. Include the downloaded files into your start page.
4. Register our tag namespace and helper in /Components/_ViewImports.cshtml: 
```
@using DevExpress.RazorComponents
addTagHelper *, DevExpress.RazorComponents
```
5. Your application is ready to use DevExpress Razor Components.

# Included Demo Modules


* Data Grid
  * Column Types
  * Templates
  * Large Datasets
* Pivot Grid
  * Data Binding Basics
  * Templates
  * Large Datasets
* Data Editors
  * Combo Box – Business Object List
  * Combo Box – Cascading Lists
  * Date Edit
  * Spin Edit
  * Text Box
* Pager



