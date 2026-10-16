using JT_CMS.Providers.MessageBusProviders;
using JT_CMS.Web.Plugins.Base;

namespace JT_CMS.Web.UI.MessageHandlers;

public class TailwindStylesMessageHandler() : IMessageHandler<string>
{
    public async Task Handle(Message<string> notification, CancellationToken cancellationToken)
    {
        switch (notification.Action)
        {
            case ActionNames.InvalidateStyles:
                var cssFilePath = Path.Combine("wwwroot", "tailwind", notification.Payload);
                if (File.Exists(cssFilePath))
                {
                    File.Delete(cssFilePath);
                }
                break;

            default:
                break;
        }
    }
}
