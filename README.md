# DevExpress UI for Razor Components

This demo application is a preview of the [DevExpress UI for Razor Components].

The DevExpress UI components featured in this demo are available for free download and can be used in your next Razor Components/Blazor app.* 

> \* Like any software preview, the DevExpress UI for Razor Components is not without fault. You should not use these products in production environments or in mission-critical applications.

# Live Demo
 
Check out this [demo in live](https://demos.devexpress.com/razor-components/).

# Set up your environment

1. Install Visual Studio 2019
2. Ensure that you have .NET Core 3 installed.
3. If you have the release version of Visual Studio 2019, please ensure that you have the "Use previews of the .NET Core SDK" option enabled.

![Enable SDK preview in VS 2019 Release"](https://raw.githubusercontent.com/DevExpress/RazorComponents/master/media/VS2019Release-EnablePreviewSDK.png)

# How to run this demo on your machine

1. Download the "**demo**" directory from this repository.
2. Open **demo/Demo.RazorComponents.sln** in Visual Studio 2019.
3. Start the application.

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
4. Obtain the client runtime directory from the GitHub repository - download all files from this directory. Put the downloaded files in the "wwwroot" directory of your project. Include that files to your start page.
5. Register our tag namespace and helper in /Components/_ViewImports.cshtml: 
```
@using DevExpress.RazorComponents
@addTagHelper *, DevExpress.RazorComponents
```
6. Your application is ready to use DevExpress Razor Components.

# Troubleshooting

## 1. DxDataGrid in Blazor

If you use Blazor (client-side hosting via MonoWASM) with DxDataGrid, you may find the following exception in the browser:

![Troubleshooting - No Generic Method 'Take' On Type System.Linq.Queryable](https://raw.githubusercontent.com/DevExpress/RazorComponents/master/media/Troubleshooting-NoGenericMethodTakeOnTypeSystemLinqQueryable.png)

> "System.InvalidOperationException: No generic method 'Take' on type 'System.Linq.Queryable' is compatible with the supplied type arguments and arguments."

Please refer the [original mono issue in github for a solution](https://github.com/mono/mono/issues/12917#issuecomment-462925005):

Or, your can just turn off the linker. To do this, navigate to your [ProjectName].Client.csproj and add the following line:

```
<BlazorLinkOnBuild>false</BlazorLinkOnBuild>
```

So, the project content looks as follows:

```
<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
  ...
    <BlazorLinkOnBuild>false</BlazorLinkOnBuild>
  </PropertyGroup>
  ...
</Project>
```

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



