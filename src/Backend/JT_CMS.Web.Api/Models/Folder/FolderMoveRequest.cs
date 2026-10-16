namespace JT_CMS.Web.Api.Models.Folder;

public class FolderMoveRequest
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public Guid ParentId { get; set; }
}
