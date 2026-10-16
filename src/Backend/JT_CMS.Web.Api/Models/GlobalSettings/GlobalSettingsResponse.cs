namespace JT_CMS.Web.Api.Models;

public class GlobalSettingsResponse
{
    public IEnumerable<string> SuperAdmins { get; set; } = [];
    public FileUploadConfig FileUpload { get; set; } = default!;
}
