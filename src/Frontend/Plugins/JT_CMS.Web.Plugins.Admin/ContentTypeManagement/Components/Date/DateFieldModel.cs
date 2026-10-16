namespace JT_CMS.Web.Plugins.Admin.ContentTypeManagement;

public class DateFieldModel : FieldModel<DateTime?>
{
    public override string Type { get; set; } = FieldTypes.DATE_TIME;
    public string? Placeholder { get; set; }
    public string? Format { get; set; }
}
