namespace JT_CMS.Web.Plugins.Admin.ContentTypeManagement;

public partial class SelectFieldSettings
{
    private List<string> SelectItems
    {
        get => Model.Options.Split("\n").Select(x => x.Trim()).ToList();
    }
}
