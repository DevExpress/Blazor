# DevExpress UI for Blazor
This project demonstrates the [DevExpress UI Components for Blazor](https://www.devexpress.com/blazor/).

The DevExpress UI components featured in this demo are available for free download and can be used in your next Blazor app.

* [Live Demo](#live-demo)
* [Examples](#examples)
* [Documentation](#documentation)
* [Version Compatibility](#version-compatibility)
* [Set Up Your Environment](#set-up-your-environment)
* [How to Run This Demo Locally](#how-to-run-this-demo-locally)
* [How to Create a New Project](#how-to-create-a-new-project)
* [Free Blazor Utilities and Dev Tools](#free-blazor-utilities-and-dev-tools)
* [Troubleshooting](#troubleshooting)
* [Included Demo Modules](#included-demo-modules)

# Live Demo
 
Check out this [demo in live](https://demos.devexpress.com/blazor/).

# Examples 

DevExpress Blazor components are shipped with GitHub feature-based examples. Refer to [examples.md](examples.md) for more information.

# Documentation 

Our online documentation is available at [docs.devexpress.com/Blazor/](https://docs.devexpress.com/Blazor/400725/blazor-components).

# Version Compatibility

The following table describes the version compatibility of .NET Core 3.0 and the DevExpress.Blazor NuGet package:

| .NET Core 3.0 version | DevExpress.Blazor.nuget version |
| ------------- | ------------- |
| [.NET Core 3.0 Release](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0/) | **19.1.9 Release**&#42; |
| [.NET Core 3.0 Release](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0/) | **19.1.8 Release**&#42; |
| [.NET Core 3.0 Release](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0/) | **19.1.7 Release**&#42; |
| [.NET Core 3.0 RC1](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-release-candidate-1/) | **0.4.1 RC** |
| [.NET Core 3.0 RC1](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-release-candidate-1/) | **0.4.0 RC** |
| [.NET Core 3.0 RC1](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-release-candidate-1/) | **0.3.3 Beta** |
| [.NET Core 3.0 Preview **9**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-9/) | **0.3.2 Beta** |
| [.NET Core 3.0 Preview **9**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-9/) | **0.3.1 Beta** |
| [.NET Core 3.0 Preview **8**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-8/) | **0.3.0 Beta** |
| [.NET Core 3.0 Preview **8**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-8/) | **0.2.0 Beta** |
| [.NET Core 3.0 Preview **7**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-7/) | **0.1.0 Beta** |
| [.NET Core 3.0 Preview **6**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-6/) | 0.0.**12** |
| [.NET Core 3.0 Preview **6**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-6/) | 0.0.**11** |
| [.NET Core 3.0 Preview **6**](https://devblogs.microsoft.com/aspnet/asp-net-core-and-blazor-updates-in-net-core-3-0-preview-6/) | 0.0.**10** |
| .NET Core 3.0 Preview **5** | 0.0.**9** |
| .NET Core 3.0 Preview **5** | 0.0.**8** |
| .NET Core 3.0 Preview **5** | 0.0.**7** |
| .NET Core 3.0 Preview **5** | 0.0.**6** |
| .NET Core 3.0 Preview **5** | 0.0.**5** |
| .NET Core 3.0 Preview **4** | 0.0.**4** |
| .NET Core 3.0 Preview **3** | 0.0.**3** |

> &#42; Starting with v19.1.7, DevExpress UI components for Blazor are distributed through a [personal NuGet feed](https://nuget.devexpress.com/). Register at [devexpress.com](https://www.devexpress.com/) to subscribe to the feed.


# Set Up Your Environment

1. Install the latest Visual Studio 2019 update.
2. Ensure that you have the latest .NET Core 3 version (from supported versions listed above) installed.

# How to Run This Demo Locally

The Blazor framework uses either WebAssembly-based .NET runtime (**client-side Blazor**) or server-side ASP.NET Core (**server-side Blazor**). Our Blazor components support both of these approaches. 

You can find appropriate demos in the repositories below:

* demo/BlazorDemo.ServerSide
* demo/BlazorDemo.ClientSide
* demo/BlazorDemo.ClientSideWithPrerendering&#42; 

> &#42; For more information, see the [Update Metadata at Runtime - Free SEO Tool](https://community.devexpress.com/blogs/aspnet/archive/2019/06/27/devexpress-blazor-update-metadata-at-runtime-free-seo-tool.aspx) blog post.

To open the required demo, do the following:

1. Download the "**demo**" and **tools** folders from the proper repository.
2. Use Visual Studio 2019 to open the solution file:
	
	**demo/BlazorDemo.ServerSide/BlazorDemo.ServerSide.sln**
	
	or
	
	**demo/BlazorDemo.ClientSide/BlazorDemo.ClientSide.sln** 
	
	or
	
	**demo/BlazorDemo.ClientSideWithPrerendering/BlazorDemo.ClientSideWithPrerendering.sln** 
	  
3. Go to [nuget.devexpress.com](https://nuget.devexpress.com), log in as a registered DevExpress customer and click **Obtain Feed URL**. The subsequent page displays a development account's NuGet Feed URL.

   Open the "Package Manager Settings".

   ![Open the "Package Manager Settings"](media/NuGetPackageManagerSettings.png)

   Add new NuGet source:
  
   ```https://nuget.devexpress.com/{your feed authorization key}/api```

   ![Add new NuGet source](media/DevExpressEarlyAccessNuGetSource.png)

4. Install the "DevExpress.Blazor" NuGet package.

   Navigate to:
   
   ![Add new NuGet source](media/NuGetPackageManagerOpenManagerMenu.png)
   
   Install the "DevExpress.Blazor" NuGet package.
   
   ![Add new NuGet source](media/VS2019Release-AddNuGetPackage.png) 

5. Start the application.

See also: 

[Official Microsoft Blazor site](https://dotnet.microsoft.com/apps/aspnet/web-apps/client)

# How to Create a New Project

Follow the steps below to try our UI for Blazor in your own application. 

1. In the "Create a new project" dialog select "Blazor App".
  
  ![Create New ASP.NET Core Web Application Project"](media/VisualStudio2019CreateNewProject_AspNetCoreWebApp.png)

  In the next step select a project template.
  
  ![Create New ASP.NET Core Web Application Project"](media/VisualStudio2019CreateNewProject_Blazor.png)

2. Go to [nuget.devexpress.com](https://nuget.devexpress.com), log in as a registered DevExpress customer and click **Obtain Feed URL**. The subsequent page displays a development account's NuGet Feed URL.

   Open the "Package Manager Settings".

   ![Open the "Package Manager Settings"](media/NuGetPackageManagerSettings.png)

   Add new NuGet source:
  
   ```https://nuget.devexpress.com/{your feed authorization key}/api```

   ![Add new NuGet source](media/DevExpressEarlyAccessNuGetSource.png)

3. Install the "DevExpress.Blazor" NuGet package.

   Navigate to:
   
   ![Add new NuGet source](media/NuGetPackageManagerOpenManagerMenu.png)
   
   Install the "DevExpress.Blazor" NuGet package.
   
   ![Add new NuGet source](media/VS2019Release-AddNuGetPackage.png) 
4. Build the project.
5. Make sure the following folder is automatically created in your project’s `wwwroot` directory:
    ```
    Lib/dx-blazor
        dx-blazor/.gitignore
        dx-blazor/modules/
        dx-blazor/dx-blazor.js
        dx-blazor/dx-blazor.css
    ```
    For existing Blazor projects, copy the DevExpress static files from the `Lib/dx-blazor` folder to the appropriate folder in your project. 

    > The `Lib/dx-blazor` folder is automatically cleared while the project is built and contains static files for an installed nuget package only. Do not store your files here.

6. Link the `dx-blazor.js` and `dx-blazor.css` files to your layout’s HEAD section:
   * For server-side Blazor, add the lines below to the _\_Host.cshtml_ file.
   * For client-side Blazor, add the lines below to the _Index.cshtml_ file.
    
    ```html
    <head>
        ...
        <link href="lib/dx-blazor/dx-blazor.css" rel="stylesheet" />
        <script src="lib/dx-blazor/dx-blazor.js"></script>
    </head>
    ```
    > Reference this JavaScript file only because the `dx-blazor/dx-blazor.js` file is the entry point for DevExpress module files.
  
7. Register DevExpress.Blazor namespace in _\_Imports.razor_ file:

   ```html
   @using DevExpress.Blazor
   ```

8. Your application is ready to use DevExpress Blazor.

# Free Blazor Utilities and Dev Tools

The following DevExpress Blazor products are available free-of-charge:

* [Document metadata tool](https://github.com/DevExpress/Blazor/tree/master/tools/DevExpress.Blazor.DocumentMetadata).
* [Anchor navigation tool](https://github.com/DevExpress/Blazor/tree/master/tools/DevExpress.Blazor.AnchorUtils).

# Troubleshooting

## 1. There was an unhandled exception on the current circuit, so this circuit will be terminated. For more details turn on detailed exceptions in 'CircuitOptions.DetailedErrors'.

If you see this error message or a similar message, add the following code to the `ConfigureServices` method declared in the *Startup.cs* file: 

```cs
services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });
```

This provides more detailed information about these errors. 

## 2. Could not find 'X' in 'window.DxBlazor'.
Earlier, our clients' scripts were manually added to a project. Now, we automatically distribute them with the NuGet Package in the lib/dx-blazor folder (see the 6th item of the [How to create a new project](https://github.com/devexpress/blazor#how-to-create-a-new-project) paragraph). So, our users may face such an issue if they reference an old version of our static files instead of the new one. For example, a similar issue was discussed in the [I have a formlayout error when running a Blazor website](https://stackoverflow.com/questions/57593583/i-have-a-formlayout-error-when-running-a-blazor-website) SO thread.
 
If solutions suggested there do not help, create an issue here or submit a ticket in our [Support Center](https://www.devexpress.com/Support/Center/Question/Create) so that we can investigate your case.

## 3. DxDataGrid in Blazor

If you use Blazor (client-side) with DxDataGrid, you may see the following exception in a browser:

![Troubleshooting - No Generic Method 'Take' On Type System.Linq.Queryable](media/Troubleshooting-NoGenericMethodTakeOnTypeSystemLinqQueryable.png)

> "System.InvalidOperationException: No generic method 'Take' on type 'System.Linq.Queryable' is compatible with the supplied type arguments and arguments."

The solution is to follow the [official Blazor documentation](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/configure-linker?view=aspnetcore-3.0).

So, you can either [Disable linking](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/configure-linker?view=aspnetcore-3.0#disable-linking-with-a-msbuild-property) or [Control linking](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/configure-linker?view=aspnetcore-3.0#control-linking-with-a-configuration-file).

In case you decide to control linking: the following types types must be added in the **Linker.xml** file:

```
    <type fullname="System.Linq.Expressions*" />
    <type fullname="System.Linq.Queryable*" />
    <type fullname="System.Linq.Enumerable*" />
    <type fullname="System.Linq.EnumerableRewriter*" />
```    

So, the **Linker.xml** file should look as follows:

```
<?xml version="1.0" encoding="UTF-8" ?>
...
<linker>
  <assembly fullname="mscorlib">
...
    <type fullname="System.Threading.WasmRuntime" />
  </assembly>
  <assembly fullname="System.Core">
...
    <type fullname="System.Linq.Expressions*" />
    <type fullname="System.Linq.Queryable*" />
    <type fullname="System.Linq.Enumerable*" />
    <type fullname="System.Linq.EnumerableRewriter*" />
  </assembly>
...
  <assembly fullname="[PUT YOUR ASSEMBLY NAME HERE]" />
</linker>
```

## 4. DxTabs are rendered incorrectly when the default Microsoft template is applied

If you create a new Blazor project based on the default Microsoft project template, the first tab of the DxTabs component can be rendered incorrectly.

This is caused by the following Microsoft issues:
* https://github.com/aspnet/AspNetCore/issues/11267
* https://github.com/aspnet/Blazor/issues/1203

To resolve this issue, write more strict style rules in the *site.css* file so that they only apply `.navbar` templates.

# Included Demo Modules

* Data Grid
  * Column Types
  * Sort Data
  * Grouping
  * Data Filter Row
  * Selection
  * Templates
  * Scrolling
  * Virtual Scrolling
  * Cascading Editors
  * Edit Form Template Validation
  * Master-Detail
  * Large Datasets
* Pivot Grid
  * Data Binding Basics
  * Templates
  * Large Datasets
  * Chart Integration
* Charts
  * Series Types
  * Dynamic Series
  * Range Series
  * Financial Series
  * Pie Series
  * Customization
  * Series Customization
* Scheduler
  * Day View
  * Work Week View
  * Week View
  * Recurring Appointments
* Data Editors
  * Calendar
  * ComboBox
  * Date Edit
  * List Box
  * Spin Edit
  * Text Box
* Navigation and Layout
  * Form Layout
  * Pager
  * Popup
  * Tabs
  * TreeView
* Form Validation

# NuGet Package Change Log

Check out thе NuGet package's [version history](changelog.md).
