# DevExpress UI for Blazor
This project demonstrates the Preview (CTP) version of [DevExpress UI Components for Blazor](https://www.devexpress.com/blazor/).

The DevExpress UI components featured in this demo are available for free download and can be used in your next Blazor app.* 

> \* Like any software preview, the DevExpress UI for Blazor is not without fault. You should not use these products in production environments or in mission-critical applications.

# Live Demo
 
Check out this [demo in live](https://demos.devexpress.com/blazor/).

# Version compatibility

The following table describes the version compatibility of .NET Core 3.0 Preview and the DevExpress.Blazor NuGet package:

| .NET Core 3.0 version | DevExpress.Blazor.nuget version |
| ------------- | ------------- |
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

# Set up your environment

1. Install the latest Visual Studio 2019 update.
2. Ensure that you have the latest .NET Core 3 version (from supported versions listed above) installed.
3. If you use the release version of Visual Studio 2019, ensure the "Use previews of the .NET Core SDK" option is enabled.

The corresponding check box's location depends on the Visual Studio build number. You can find the check box here:

![Create New ASP.NET Core Web Application Project"](media/VS2019Release-EnablePreviewSDK.png)

or here:

![Create New ASP.NET Core Web Application Project"](media/VS2019Release-EnablePreviewSDK_2.png)

# How to run this demo locally

The Blazor framework uses either WebAssembly-based .NET runtime (**client-side Blazor**) or server-side ASP.NET Core (**server-side Blazor**). Our Blazor components support both of these approaches. 

You can find appropriate demos in the repositories below:

* demo/BlazorDemo.ServerSide
* demo/BlazorDemo.ClientSide
* demo/BlazorDemo.ClientSideWithPrerendering&#42; 

> &#42; For more information, see the [Update Metadata at Runtime - Free SEO Tool](https://community.devexpress.com/blogs/aspnet/archive/2019/06/27/devexpress-blazor-update-metadata-at-runtime-free-seo-tool.aspx) blog post.

To open the required demo, do the following:

1. Download the "**demo**" folder from the proper repository.
2. Use Visual Studio 2019 to open the solution file:
	
	**demo/BlazorDemo.ServerSide/BlazorDemo.ServerSide.sln**
	
	or
	
	**demo/BlazorDemo.ClientSide/BlazorDemo.ClientSide.sln** 
	
	or
	
	**demo/BlazorDemo.ClientSideWithPrerendering/BlazorDemo.ClientSideWithPrerendering.sln** 
	  
3. Start the application.

See also: 

[Official Microsoft Blazor site](https://dotnet.microsoft.com/apps/aspnet/web-apps/client)

# How to create a new project

Follow the steps below to try our UI for Blazor in your own application. 

1. Create a new solution using the "Blazor (server-side)" or "Blazor" template in Visual Studio 2019.

  In the "Create a new project" dialog select "ASP.NET Core Web Application (where the language is C#).
  
  ![Create New ASP.NET Core Web Application Project"](media/VisualStudio2019CreateNewProject_AspNetCoreWebApp.png)

  In the next step ensure that an "ASP.NET Core 3.\*" framework is selected, and select the "Blazor (server-side)" project template.
  
  ![Create New ASP.NET Core Web Application Project"](media/VisualStudio2019CreateNewProject_Blazor.png)

2. Register the DevExpress Early Access feed in Visual Studio's NuGet Package Manager.

  Open the "Package Manager Settings".

  ![Open the "Package Manager Settings"](media/NuGetPackageManagerSettings.png)

  Add new NuGet source:
  
  ```https://nuget.devexpress.com/early-access/api```

  ![Add new NuGet source](media/DevExpressEarlyAccessNuGetSource.png)

3. Install the "DevExpress.Blazor" NuGet package.

   Navigate to:
   
   ![Add new NuGet source](media/NuGetPackageManagerOpenManagerMenu.png)
   
   Select the "Early Access" NuGet package source you have just created in the "Package source" combo box.

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

# Troubleshooting

## 1. DxDataGrid in Blazor

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

## 2. The "Early Access" NuGet Feed is empty in Visual Studio

If you don't see packages in the ```https://nuget.devexpress.com/early-access/api``` NuGet feed, make sure that the "Include prerelease" option is selected:
![Include prerelease](media/VisualStudio2019NuGetIncludePrerelease.png)

# Included Demo Modules

* Data Grid
  * Column Types
  * Sort Data
  * Templates
  * Scrolling
  * Virtual Scrolling
  * Cascading Editors
  * Edit Form Template Validation
  * Large Datasets
* Pivot Grid
  * Data Binding Basics
  * Templates
  * Large Datasets
  * Chart Integration
* Charts
  * Series Types
  * Dynamic Series
  * Customization  
* Scheduler
  * Day View
  * Work Week View
  * Week View
  * Recurring Appointments
* Data Editors
  * ComboBox – Business Object List
  * ComboBox - Virtual Scrolling
  * ComboBox - Allow Input
  * ComboBox - Incremental Filtering
  * ComboBox - NullText
  * ComboBox – Cascading Lists
  * Spin Edit
  * Date Edit  
  * Text Box
* TreeView
* Form Layout
* Form Validation
* Tabs
* Pager

# NuGet Package Change Log

Check out thе NuGet package's [version history](changelog.md).
