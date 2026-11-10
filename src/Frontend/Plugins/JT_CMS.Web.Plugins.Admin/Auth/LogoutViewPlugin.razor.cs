using JT_CMS.Web.ApiClients.Services;

namespace JT_CMS.Web.Plugins.Admin.Auth;

public partial class LogoutViewPlugin
{
    [Inject]
    private AuthManager AuthManager { get; set; } = default!;

    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        var httpContext = HttpContext ?? HttpContextAccessor?.HttpContext;
        if (httpContext != null)
            await AuthManager.Logout(httpContext);

        NavigateTo("/", true);
    }
}
