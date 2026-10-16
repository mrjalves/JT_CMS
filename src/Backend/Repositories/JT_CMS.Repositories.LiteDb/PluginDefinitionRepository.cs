namespace JT_CMS.Repositories.LiteDb;

public class PluginDefinitionRepository(ILiteDBContext liteDbContext, IApiExecutionContext apiExecutionContext) : AuditableEntityRepository<PluginDefinition>(liteDbContext, apiExecutionContext), IPluginDefinitionRepository;
