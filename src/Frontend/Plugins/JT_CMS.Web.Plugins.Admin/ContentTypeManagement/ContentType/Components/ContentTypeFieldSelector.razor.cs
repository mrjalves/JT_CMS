namespace JT_CMS.Web.Plugins.Admin.ContentTypeManagement;

public partial class ContentTypeFieldSelector
{
    [Parameter]
    public EventCallback<string> OnSelect { get; set; }

    [Parameter]
    public EventCallback OnCancel { get; set; }

    private async Task OnClick(string type)
    {
        await OnSelect.InvokeAsync(type);
    }

}
