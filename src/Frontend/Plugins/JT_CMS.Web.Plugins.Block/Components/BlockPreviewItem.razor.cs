namespace JT_CMS.Web.Plugins.Block;

public partial class BlockPreviewItem
{
    [Parameter]
    public BlockDetailResponse Block { get; set; } = default!;
}