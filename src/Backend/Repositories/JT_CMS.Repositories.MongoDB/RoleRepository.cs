namespace JT_CMS.Repositories.MongoDB;

public class RoleRepository(IMongoDBContext mongoDbContext, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Role>(mongoDbContext, apiExecutionContext), IRoleRepository
{
}
