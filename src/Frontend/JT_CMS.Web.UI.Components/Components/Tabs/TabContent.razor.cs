namespace JT_CMS.Web.UI.Components;

public partial class TabContent
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
