namespace JT_CMS.Repositories.EFCore.DbModels;

[Table("Settings")]
public class SettingsModel : AuditableEntityModel
{
    public ICollection<SettingValuesModel> Values { get; set; } = []; // Navigation property
}
