namespace JT_CMS.Web.Api.Models.Folder;

public class FolderRenameRequest
{
    [Required]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; } = default!;
}
