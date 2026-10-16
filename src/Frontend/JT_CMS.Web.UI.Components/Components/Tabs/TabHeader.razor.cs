namespace JT_CMS.Web.UI.Components;

public partial class TabHeader
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
