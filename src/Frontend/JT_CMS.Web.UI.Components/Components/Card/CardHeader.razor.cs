namespace JT_CMS.Web.UI.Components;

public partial class CardHeader
{
    [Parameter]
    public string? Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
