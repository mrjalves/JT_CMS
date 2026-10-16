namespace JT_CMS.Repositories.Caching;

public class PluginDefinitionRepository(IPluginDefinitionRepository repository, ICacheProvider cacheProvider) : AuditableEntityRepository<PluginDefinition>(repository, cacheProvider), IPluginDefinitionRepository
{
}
