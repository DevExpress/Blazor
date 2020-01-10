# Localization

Localization is the process of translating a product into a different language. DevExpress Blazor components ship localizable resources for UI elements, such as button captions, menu items, error messages, and dialog boxes.

The localization mechanism depends on your application’s [hosting model](https://docs.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-3.0): Blazor server (ASP.NET Core) or Blazor WebAssembly.

## Blazor Server

DevExpress components for server-side Blazor use the standard localization mechanism from the .NET framework - Satellite Resource Assemblies. For more information, refer to the [Creating Satellite Assemblies](https://docs.microsoft.com/en-us/dotnet/framework/resources/creating-satellite-assemblies-for-desktop-apps?view=netframework-4.8) MSDN article.
DevExpress components ship NuGet packages with predefined satellite resource assemblies for the following languages and cultures:

| Nuget package postfix      | Corresponding culture |
| --------- | -----:|
| de  | German |
| es     |   Spanish |
| ja      |    Japanese |
| ru      |    Russian |


To define satellite assemblies for other cultures, follow the steps below: 
1. Create the Resources folder in your project. 
2. Add a  LocalizationRes.resx file for a default culture to the Resources folder. 
3. Add *.resx files for other cultures to the Resources folder. 

![](media/LocalizationViaResx.png)

After that, DevExpress Blazor components start to use the added satellite assemblies to localize component resources according to the user’s culture. For more information about how Blazor applications select the user culture, refer to the [Localization](https://docs.microsoft.com/en-us/aspnet/core/blazor/components?view=aspnetcore-3.1#localization) MSDN article.
The [Localization example](https://www.devexpress.com/Support/Center/Example/Details/T850867/how-to-localize-devexpress-blazor-components) demonstrates how to localize DevExpress Blazor components via Satellite Resource Assemblies.

## Blazor WebAssembly

Currently, there is no official or recommended approach on how to localize Blazor WebAssembly applications. 
DevExpress components for Blazor WebAssembly are localized via the [IDxLocalizationService](http://docs.devexpress.com/Blazor/DevExpress.Blazor.Localization.IDxLocalizationService) interface implementation. For more information, refer to the [Localization example](https://www.devexpress.com/Support/Center/Example/Details/T850867/how-to-localize-devexpress-blazor-components).
