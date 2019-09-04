# DevExpress Blazor Anchor Navigation Tool

The DevExpress Anchor Navigation tool automatically scrolls a page to an anchor in the following instances:

* When an end-user clicks a hyperlink with an anchor;
* When a page is first opened and contains an anchor ID within its URL (for example, https://demos.devexpress.com/blazor/SchedulerViewTypes#DayView)

The tool also includes the Blazor **AnchorLink** component. Use this component to create in-page navigation links as needed:

```html
<AnchorLink class="nav-link py-3 px-4" href="#MySection1">My Section 1</AnchorLink>
```
	
When an end-user clicks the link, the page scrolls to the corresponding anchor:

```html
<h2 id="MySection1">Section 1</h2>
<p>Lorem ipsum dolor sit amet...</p>
<h2 id="MySection2">Section 2</h2>
<p>Quisque imperdiet risus quis nisl vulputate...</p>
```

## Add the tool to a project

Follow the steps below to add the tool to your Blazor application.

1. Download and add the **DevExpress.Blazor.AnchorUtils.csproj** project to your Blazor solution.

2. Register the **DevExpress.Blazor.AnchorUtils** namespace in the _\_Imports.razor_ file:

```
@using DevExpress.Blazor.AnchorUtils
```
   
3. Add the non-visual **AnchorUtilsComponent** component to the _Shared/MainLayout.razor_ file:

```html
<div class="main">
	...
	<div class="content px-4"> 
		@Body 
	</div> 
</div>
<AnchorUtilsComponent />
```
	
4. Copy `wwwroot/anchor-utils.js` file from the anchor navigation source code to your project’s `wwwroot` folder or its subfolders.

* For **server-side Blazor**, register this file in _Pages/\_Host.cshtml_ file.

* For **client-side Blazor**, register this file in _wwwroot/index.html_ file.

5. (optional): If your page layout contains a pinned (non-scrollable) header (like the standard Blazor project), edit the anchor-utils.js file and update the following code to obtain vertical scroll offset appropriate for your application:

```javascript
y -= document.querySelector(".main .top-row").offsetHeight;
```
	
**Note**: If a client-side Blazor application is deployed as [a set of static files](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/client-side?view=aspnetcore-3.0#standalone-deployment), the web server provides the index.html file by a root URL (e.g., `https://mywebsite.com/`) only. If a browser requests a specific page by its direct URL (e.g., `https://mywebsite.com/MyPage1`), the web server raises a 404-code exception. Refer to the [Getting 404 on pages other than root when Blazor hosted in IIS](https://www.reddit.com/r/Blazor/comments/c0n2c5/getting_404_on_pages_other_than_root_when_blazor/) to learn more about this issue and a possible solution. The solution requires [URL Rewrite Module](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/blazor/client-side?view=aspnetcore-3.0#install-the-url-rewrite-module).