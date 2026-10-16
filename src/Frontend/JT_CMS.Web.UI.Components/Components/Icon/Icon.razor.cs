using System.Resources;

namespace JT_CMS.Web.UI.Components;

public partial class Icon
{
    private MarkupString? Content { get; set; }

    [Inject(Key = "JT_CMS.Web.UI.Components.IconResource")]
    public required ResourceManager ResourceManager { get; set; }

    [Parameter]
    [CSSProperty]
    public Color Color { get; set; } = Color.Default;

    [Parameter]
    public IconName Name { get; set; } = IconName.Default;

    [Parameter]
    [CSSProperty]
    public IconSize Size { get; set; } = IconSize.Default;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Content = (MarkupString)(ResourceManager.GetString(Name.ToString()) ?? throw new Exception("Invalid Icon name: \"" + Name.ToString() + "\""));
    }
}
