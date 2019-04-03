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

In the "Create a new project" Visual Studio 2019 dialog select "ASP.NET Core Web Application (where the language is C#).
![Create New ASP.NET Core Web Application Project"](https://raw.githubusercontent.com/DevExpress/RazorComponents/master/media/VisualStudio2019CreateNewProject_AspNetCoreWebApp.png)

In the next step ensure you have "ASP.NET Core 3.*" framework is selected, and select "Razor Components" project template.
![Create New ASP.NET Core Web Application Project"](https://raw.githubusercontent.com/DevExpress/RazorComponents/master/media/VisualStudio2019CreateNewProject_RazorComponents.png)

2. Register the DevExpress Early Access feed in Visual Studio's NuGet Package Manager.

Open the "Package Manager Settings"
![Open the "Package Manager Settings"](https://raw.githubusercontent.com/DevExpress/RazorComponents/master/media/NuGetPackageManagerSettings.png)

Add new NuGet source:
```https://nuget.devexpress.com/early-access/api```
![Add new NuGet source](https://raw.githubusercontent.com/DevExpress/RazorComponents/master/media/DevExpressEarlyAccessNuGetSource.png)

3. Install the "DevExpress.RazorComponents" NuGet package.
4. Obtain the client runtime from this GitHub repository - download all files from the "client-runtime" directory. Include the downloaded files into your start page.
5. Register our tag namespace and helper in /Components/_ViewImports.cshtml: 
```
@using DevExpress.RazorComponents
@addTagHelper *, DevExpress.RazorComponents
```
6. Your application is ready to use DevExpress Razor Components.

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



