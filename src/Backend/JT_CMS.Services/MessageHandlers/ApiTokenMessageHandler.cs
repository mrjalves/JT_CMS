using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.Extensions.Configuration;

namespace JT_CMS.Services.MessageHandlers;

public class ApiTokenMessageHandler(IApiTokenService apiTokenService, IConfiguration configuration) : IMessageHandler<SetupTemplate>
{
    public async Task Handle(Message<SetupTemplate> notification, CancellationToken cancellationToken)
    {
        switch (notification.Action)
        {
            case ActionNames.SetupStarted:
                var existingTokens = await apiTokenService.GetAll(cancellationToken);
                var existingDefault = existingTokens.FirstOrDefault(x => x.Name == "Full Access");
                if (existingDefault != null)
                {
                    await apiTokenService.Delete(existingDefault.Id, cancellationToken);
                }

                var apiToken = await apiTokenService.Create(GetDefaultApiToken(), cancellationToken);
                var newKey = apiToken.Key + ":" + apiToken.Secret;

                // Update in-memory configuration immediately so subsequent API requests in the same process use the new key
                configuration["ClientSettings:Key"] = newKey;

                // Update appsettings.json and appsettings.Production.json (if present)
                foreach (var fileName in new[] { "appsettings.json", "appsettings.Production.json" })
                {
                    var appSettingsFilePath = Path.Combine(fileName);
                    if (!System.IO.File.Exists(appSettingsFilePath))
                        continue;

                    var text = System.IO.File.ReadAllText(appSettingsFilePath);
                    var jsonNode = JsonNode.Parse(text);
                    if (jsonNode?["ClientSettings"] is JsonObject clientSettingsNode)
                    {
                        clientSettingsNode["Key"] = newKey;
                        var output = JsonSerializer.Serialize(jsonNode, new JsonSerializerOptions() { WriteIndented = true });
                        System.IO.File.WriteAllText(appSettingsFilePath, output);
                    }
                }

                if (configuration is IConfigurationRoot configRoot)
                {
                    configRoot.Reload();
                    configuration["ClientSettings:Key"] = newKey;
                }

                break;

            default:
                break;
        }
    }

    private static ApiToken GetDefaultApiToken()
    {
        return new ApiToken
        {
            Id = Guid.NewGuid(),
            Name = "Full Access",
            Description = "Full Access Token",
            ExpireAt = null,
            Policies = [new Policy { Area = "Global", Actions = ["All Actions"] }],
            Enabled = true
        };
    }
}
