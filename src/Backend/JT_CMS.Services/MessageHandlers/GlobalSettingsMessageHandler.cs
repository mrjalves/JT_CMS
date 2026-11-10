namespace JT_CMS.Services.MessageHandlers;

public class GlobalSettingsMessageHandler(IGlobalSettingsService globalSettingsService) : IMessageHandler<SetupTemplate>
{
    public async Task Handle(Message<SetupTemplate> notification, CancellationToken cancellationToken)
    {
        switch (notification.Action)
        {
            case ActionNames.SetupStarted:
                var superAdmins = new List<string> { notification.Payload.Username };
                try
                {
                    var existing = await globalSettingsService.Get(cancellationToken);
                    if (existing?.SuperAdmins != null)
                    {
                        foreach (var admin in existing.SuperAdmins)
                        {
                            if (!string.IsNullOrWhiteSpace(admin) && !superAdmins.Contains(admin, StringComparer.OrdinalIgnoreCase))
                                superAdmins.Add(admin);
                        }
                    }
                }
                catch
                {
                    // GlobalSettings does not exist yet
                }

                var globalSettings = new GlobalSettings
                {
                    SuperAdmins = superAdmins
                };
                await globalSettingsService.Update(globalSettings, cancellationToken);
                break;

            case ActionNames.SetupCompleted:
                break;

            default:
                break;
        }
    }
}
