namespace JT_CMS.Web.UI.Components;

public partial class CardBody
{
    [Parameter]
    public RenderFragment ChildContent { get; set; } = default!;
}
