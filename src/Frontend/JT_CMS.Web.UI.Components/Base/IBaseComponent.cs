namespace JT_CMS.Web.UI.Components;

public interface IBaseComponent
{
    bool Visible { get; set; }
    string? Class { get; set; }
    string? CSSName { get; set; }
    IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
    string GetDefaultCSSName();
}
