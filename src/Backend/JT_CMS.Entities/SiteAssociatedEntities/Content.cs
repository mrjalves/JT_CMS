namespace JT_CMS.Entities;

public class Content : SiteAssociatedEntity
{
    public Guid TypeId { get; set; }
    public Dictionary<string, object?> Data { get; set; } = [];
}
