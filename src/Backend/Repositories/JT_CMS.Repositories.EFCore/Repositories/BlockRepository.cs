namespace JT_CMS.Repositories.EFCore;

public class BlockRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Block, BlockModel>(dbContext, mapper, apiExecutionContext), IBlockRepository
{
}
