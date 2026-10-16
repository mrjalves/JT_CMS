namespace JT_CMS.Repositories.EFCore;

public class PageRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Page, PageModel>(dbContext, mapper, apiExecutionContext), IPageRepository
{
}
