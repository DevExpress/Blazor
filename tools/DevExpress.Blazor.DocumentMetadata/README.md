# DevExpress SEO Metadata Tool

As you may know, the Blazor framework does not provide any way to change a document's metadata at runtime (for document metadata: page title, meta tags, and other SEO-related data).

Our utility fixes this issue and is available free of charge.

## How to Use the DevExpress SEO Metadata Tool

To get started, you'll need to add our SEO Metadata Utility to your project:

1. Download the DevExpress Document Metadata project source code.
1. [Add](https://docs.microsoft.com/en-us/sql/ssms/solution/add-an-existing-project-to-a-solution?view=sql-server-2017) the Document Metadata project to your Blazor solution in Visual Studio.

## Configure the DevExpress SEO Metadata Tool

An approach used to configure the tool depends on your application's [hosting model](https://docs.microsoft.com/en-us/aspnet/core/blazor/hosting-models?view=aspnetcore-3.0).

#### Server-Side Blazor

To add the default document metadata, follow the steps below:

1. Add the `DocumentMetadata` component to a page header:

    ```html
    <head>
        @(await Html.RenderComponentAsync<DocumentMetadataComponent>())
        ...
    </head>
    ```

2. Call the `AddDocumentMetadata()` extension method to register default document metadata:

    ```cs
    using DevExpress.Blazor.DocumentMetadata;
    namespace BlazorDemo.ServerSide
    {
        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddDocumentMetadata((IServiceProvider serviceProvider,
                    IDocumentMetadataRegistrator registrator) => {
                    registrator.Default()
                        .Title("Blazor UI Components")
                    ...
                });
            }
            ...
        }
    }
    ```
    
    Note, the `registrator.Default()` method returns a document metadata builder. Use this builder to register metadata defaults for all pages:
  
    ```cs
    registrator.Default()
      .Base("~/")
      .Charset("utf-8")
      .TitleFormat("Demo: {0} | DevExpress")
      .Viewport("width=device-width, initial-scale=1.0")
      .OpenGraph("url", https://dxpr.es/2WogLq7)
      ...
    ```
  
To add the custom document metadata, follow the steps below:

1. You can also load metadata from a database, text file, or any other supported storage location. For example, in our demo application, we store the pages' metadata in a 'DemoConfiguration' section of the `appsettings.json` file:

    ```cs
    {
      "DemoConfiguration": {
        "SiteMode": false,
        "DemoPages": [
          {
            "Url": "",
            "Title": "Blazor UI Components",
            "NavLinkText": "Overview",
            "Icon": "images/Overview.svg",
            "IsUpdated": true,
            "TitleFormat": "Demos: {0} | DevExpress"
          },
          {
            "Url": "GridColumnTypes",
            "Title": "Grid - Column Types",
            "Icon": "images/GridColumnType.svg"
          },
          ...
    ```
    The following code loads metadata from `appsettings.json`:
  
    ```cs
    services.Configure<DemoConfiguration> Configuration.GetSection("DemoConfiguration"));
    ```
  
2. Call the `AddDocumentMetadata()` method to add custom metadata to web pages:

    ```cs
    services.AddDocumentMetadata((serviceProvider, registrator) => {
        var config = serviceProvider.GetService<IOptions<DemoConfiguration>>().Value;
        config.RegisterPagesMetadata(registrator);
    });
    ```
    The `config.RegisterPagesMetadata()` method populates the service with custom metadata. The following code assigns default metadata for all pages and also specifies the page title for each page:
  
    ```cs
    public class DemoConfiguration
    {
        public List<DemoPageConfiguration> DemoPages { get; set; }
        public void RegisterPagesMetadata(IDocumentMetadataRegistrator registrator)
        {
            registrator.Default()
                .Charset("utf-8")
                .TitleFormat("Demo: {0} | DevExpress");

            DemoPages.ForEach(pageMetadata => {
                IDocumentMetadataBuilder metadataBuilder = registrator.Page(pageMetadata.Url);
                metadataBuilder.Title(pageMetadata.Title);
                if (!string.IsNullOrEmpty(pageMetadata.TitleFormat))
                    metadataBuilder.TitleFormat(pageMetadata.TitleFormat);
            });
        }
    }
    ```
  
    The `TitleFormat()` method sets the format for text assigned using the `Title()` method. If the page title format is not set then the page title is displayed as is.
  
#### Client-Side Blazor

Client-side Blazor apps present a challenge because they only render page markup after the web assembly has been loaded. Since search engine crawlers do not read web assembly files, they only get to scan simple HTML pages with static content and meta tags.

So, to update metadata for a client-side Blazor application, you'll need to create both a server-side and client-side Blazor projects. The client-side project code is compiled to a web assembly and will work in the end user's browser. While the server-side project will host the client-side project on your server, deliver the web assembly to the client,and handle requests to the server side. This approach is based on Microsoft's recommendation for [Client-side Blazor applications with pre-rendering](https://github.com/danroth27/ClientSideBlazorWithPrerendering).

To add a default document metadata, add metatags to the `Page/_Host.cshtml` page located in the server-side project. You can see an example of this [here](https://github.com/danroth27/ClientSideBlazorWithPrerendering/blob/master/ClientSideBlazorWithPrerendering.Server/Pages/_Host.cshtml).

To add a custom document metadata, follow the steps below:

1. Enable pre-rendering in your blazor application because it allows you to add page-specific meta tags and improve your website's SEO parameters. Start by adding a reference to your client-side Blazor project to the server-side Blazor project.

2. Call the `app.UseClientSideBlazorFiles()` method in the server-side application's `Startup.cs` file. Use the client-side application's `Startup` class as a generic parameter:

    ```cs
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        …
        app.UseClientSideBlazorFiles<ClientSide.Startup>();

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapDefaultControllerRoute();
            endpoints.MapFallbackToPage("/_Host");
        });
    }
    ```
3. Once page pre-render is enabled, call the render the `RenderStaticComponentAsync()` method with the `DocumentMetadata` component in the `Page/_Host.razor` page of your server-side Blazor application:

    ```html
    <head>
        @(await Html.RenderStaticComponentAsync<DocumentMetadataComponent>())
    </head>
    ```
    Note that no additional content is allowed inside the 'head' tags in this case.

4. Register the `DemoConfiguration` options and the `DocumentMetadata` service in both client-side and server-side Blazor projects:

    ```cs
    services.AddSingleton<IOptions<DemoConfiguration>, ClientSideDemoConfiguration>(); services.AddDocumentMetadata((serviceProvider, registrator) =>
    {
        DemoConfiguration config = serviceProvider.GetService<IOptions<DemoConfiguration>>().Value;
        config.RegisterPagesMetadata(registrator);
    });
    ```
    The `appsettings.json` configuration file is not transferred to the client side. Therefore, page metadata is populated in the `PopulateDemoPages()` method of the `DemoConfiguration` class.
  
    ```cs
    void PopulateDemoPages()
    {
        DemoPages.Add(new DemoPageConfiguration() {
            Url = "",
            Title = "Blazor UI Components",
            NavLinkText = "Overview",
            Icon = "images/Overview.svg",
            IsUpdated = true,
            TitleFormat = "Demos: {0} | DevExpress"
        });
        DemoPages.Add(new DemoPageConfiguration() {
            Url = "GridColumnTypes",
            Title = "Grid - Column Types",
            Icon = "images/GridColumnType.svg"
        });
    …
    ```
    Since we have a reference to the client-side Blazor project in the server-side project, this class is available in both projects. You can use it in the server-side Blazor project instead of `appsettings.json`.

5. Add the `DocumentMetadata` component to the Components Application Builder in your client-side Blazor project:

    ```cs
    public void Configure(IComponentsApplicationBuilder app)
    {
        app.AddComponent<App>("app");
        app.AddComponent<DocumentMetadataComponent>("head");
    }
    ```

    This way, the DocumentMetadata component renders content inside the 'head' HTML tag when an end-user changes web pages in a browser.

The SEO tool is now enabled.

## Examples

An example of a server-side Blazor application with the use of the SEO Metadata tool:

[https://github.com/DevExpress/Blazor/tree/master/demo/BlazorDemo.ServerSide](https://github.com/DevExpress/Blazor/tree/master/demo/BlazorDemo.ServerSide)

An example of a client-side Blazor application with the use of the SEO Metadata tool:

[https://github.com/DevExpress/Blazor/tree/master/demo/BlazorDemo.ClientSideWithPrerendering](https://github.com/DevExpress/Blazor/tree/master/demo/BlazorDemo.ClientSideWithPrerendering)

  
  

