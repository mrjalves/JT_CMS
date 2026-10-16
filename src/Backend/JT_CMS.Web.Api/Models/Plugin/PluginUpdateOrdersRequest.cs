using JT_CMS.Services.Models;

namespace JT_CMS.Web.Api.Models;

public class PluginUpdateOrdersRequest
{
    [Required]
    public List<PluginOrder> PluginOrders { get; set; } = [];
}
