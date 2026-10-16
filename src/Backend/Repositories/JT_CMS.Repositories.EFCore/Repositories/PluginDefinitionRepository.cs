namespace JT_CMS.Repositories.EFCore;

public class PluginDefinitionRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : AuditableEntityRepository<PluginDefinition, PluginDefinitionModel>(dbContext, mapper, apiExecutionContext), IPluginDefinitionRepository;
