namespace JT_CMS.Web.UI.Components;

public partial class Badge
{
    [Parameter]
    [CSSProperty]
    public Color Color { get; set; } = Color.Default;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
