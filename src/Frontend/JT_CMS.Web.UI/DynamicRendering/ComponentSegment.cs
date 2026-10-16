namespace JT_CMS.Web.UI.DynamicRendering;

public class ComponentSegment : Segment
{
    public Type Type { get; set; } = default!;
    public Dictionary<string, string> Attributes { get; set; } = [];
}
