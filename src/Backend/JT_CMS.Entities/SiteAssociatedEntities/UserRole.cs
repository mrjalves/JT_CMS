namespace JT_CMS.Entities;

public class UserRole : SiteAssociatedEntity
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
}
