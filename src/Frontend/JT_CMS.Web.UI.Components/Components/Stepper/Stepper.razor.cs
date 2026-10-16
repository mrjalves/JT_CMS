namespace JT_CMS.Web.UI.Components;

public partial class Stepper
{
    [Parameter]
    [CSSProperty]
    public bool Vertical { get; set; } = true;

    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
