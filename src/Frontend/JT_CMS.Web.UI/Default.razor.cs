using JT_CMS.Web.ApiClients.Services;
using JT_CMS.Web.UI.DynamicRendering;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http;

namespace JT_CMS.Web.UI;

public partial class Default
{
    [Inject]
    private ILayoutProcessor LayoutProcessor { get; set; } = default!;

    [Inject]
    public ViewState ViewState { get; set; } = default!;

    [Parameter]
    public string? Route { get; set; }

    [Inject]
    public NavigationManager NavigationManager { set; get; } = default!;

    [Inject]
    public SetupManager SetupManager { set; get; } = default!;

    [Inject]
    public IHttpContextAccessor? HttpContextAccessor { get; set; }

    protected override async Task OnInitializedAsync()
    {
        // check if setup is not done
        // if not it should be redirected to /setup route
        // if you see and exception here in development time, continue running! it's a known issue in Blazor
        if (!await SetupManager.IsInitialized() && !NavigationManager.Uri.ToLower().EndsWith("/setup"))
        {
            RedirectTo("/setup");
            return;
        }

        var currentUri = new Uri(NavigationManager.Uri);
        var currentPath = currentUri.LocalPath;

        if (!currentPath.StartsWith("/auth/", StringComparison.OrdinalIgnoreCase) &&
            !currentPath.Equals("/setup", StringComparison.OrdinalIgnoreCase))
        {
            var requiresAuth = !ViewState.Page.HasViewAccess ||
                               (ViewState.Type == ViewStateType.PageEdit && !ViewState.Page.HasAdminAccess);

            if (requiresAuth && string.IsNullOrEmpty(ViewState.User?.UserName))
            {
                var returnUrl = Uri.EscapeDataString(currentUri.PathAndQuery);
                RedirectTo($"/auth/login?redirectTo={returnUrl}");
                return;
            }
        }
    }

    private void RedirectTo(string path)
    {
        var httpContext = HttpContextAccessor?.HttpContext;
        if (httpContext != null && !httpContext.Response.HasStarted)
        {
            if (httpContext.Request.Headers.ContainsKey("blazor-enhanced-nav"))
            {
                httpContext.Response.Headers["blazor-enhanced-nav-redirect-location"] = path;
                httpContext.Response.StatusCode = StatusCodes.Status200OK;
                return;
            }
            httpContext.Response.Redirect(path);
        }
        else
        {
            NavigationManager.NavigateTo(path, true);
        }
    }

    protected RenderFragment RenderDynamicContent(string content) => builder =>
    {
        if (string.IsNullOrEmpty(content))
            return;

        var parameters = new Dictionary<string, object>
        {
            { "user", ViewState.User },
            { "site", ViewState.Site },
            { "page", ViewState.Page },
            { "plugins", ViewState.Plugins }
        };

        var segments = LayoutProcessor.ProcessSegments(content, parameters);
        var index = 0;
        foreach (var segment in segments)
        {
            if (segment.GetType() == typeof(HtmlSegment))
            {
                var htmlSegment = segment as HtmlSegment;
                builder.AddContent(index, (MarkupString)htmlSegment!.Content);
            }
            else if (segment.GetType() == typeof(ComponentSegment))
            {
                var componentSegment = segment as ComponentSegment;
                builder.OpenComponent(index, componentSegment!.Type);

                var attributeIndex = 0;
                foreach (var attribute in componentSegment.Attributes)
                {
                    builder.AddComponentParameter(attributeIndex, attribute.Key, attribute.Value);
                    attributeIndex++;
                }
                builder.AddComponentRenderMode(PluginRenderMode());

                builder.CloseComponent();
            }
            index++;
        }
    };

    private InteractiveServerRenderMode? PluginRenderMode()
    {
        if (ViewState.Page.Locked)
            return null;

        if (ViewState.Type == ViewStateType.PagePreview || ViewState.Type == ViewStateType.PageEdit)
            return RenderMode.InteractiveServer;

        if (ViewState.Type == ViewStateType.Default && ViewState.Page.HasAdminAccess)
            return RenderMode.InteractiveServer;

        return null;
    }
}
