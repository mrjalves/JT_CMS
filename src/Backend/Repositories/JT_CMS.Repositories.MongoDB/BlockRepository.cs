namespace JT_CMS.Repositories.MongoDB;

public class BlockRepository(IMongoDBContext mongoDbContext, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Block>(mongoDbContext, apiExecutionContext), IBlockRepository
{
}
