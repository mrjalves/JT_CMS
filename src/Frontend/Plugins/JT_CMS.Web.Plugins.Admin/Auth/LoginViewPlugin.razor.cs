using JT_CMS.Web.ApiClients.Services;

namespace JT_CMS.Web.Plugins.Admin.Auth;

public partial class LoginViewPlugin
{
    public const string FORM_NAME = "LoginForm";

    [Inject]
    private AuthManager AuthManager { get; set; } = default!;

    [CascadingParameter]
    private HttpContext HttpContext { get; set; } = default!;

    [SupplyParameterFromForm(FormName = FORM_NAME)]
    private UserLoginRequest Model { get; set; } = new();

    private async Task OnSubmit()
    {
        var httpContext = HttpContext ?? HttpContextAccessor?.HttpContext;
        if (httpContext != null)
        {
            await AuthManager.Login(httpContext, Model.Username, Model.Password, Model.RememberMe);
        }

        var uri = new Uri(NavigationManager.Uri);
        var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
        var redirectTo = query["redirectTo"];

        if (!string.IsNullOrEmpty(redirectTo))
        {
            NavigateTo(Uri.UnescapeDataString(redirectTo), true);
        }
        else
        {
            NavigateTo("/", true);
        }
    }
}
