namespace JT_CMS.Services.MessageHandlers;

public class PluginDefinitionMessageHandler(IPluginDefinitionService pluginDefinitionService) : IMessageHandler<SetupTemplate>
{
    public async Task Handle(Message<SetupTemplate> notification, CancellationToken cancellationToken)
    {
        switch (notification.Action)
        {
            case ActionNames.SetupStarted:
                var existingDefs = (await pluginDefinitionService.GetAll(cancellationToken)).ToList();
                foreach (var pluginDef in notification.Payload.PluginDefinitions)
                {
                    var existing = existingDefs.FirstOrDefault(x => x.Name.Equals(pluginDef.Name, StringComparison.OrdinalIgnoreCase));
                    if (existing != null)
                    {
                        pluginDef.Id = existing.Id;
                        continue;
                    }
                    await pluginDefinitionService.Create(pluginDef, cancellationToken);
                }

                break;

            default:
                break;
        }
    }
}
