namespace JT_CMS.Repositories.EFCore;

public class LayoutRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Layout, LayoutModel>(dbContext, mapper, apiExecutionContext), ILayoutRepository;
