
namespace JT_CMS.Web.Plugins.Admin.ContentTypeManagement;

public class BooleanFieldModel : FieldModel<bool>
{
    public override string Type { get; set; } = FieldTypes.BOOLEAN;
}
