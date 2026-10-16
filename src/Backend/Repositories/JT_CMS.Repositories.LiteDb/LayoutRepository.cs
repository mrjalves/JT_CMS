namespace JT_CMS.Repositories.LiteDb;

public class LayoutRepository : SiteAssociatedRepository<Layout>, ILayoutRepository
{
    public LayoutRepository(ILiteDBContext liteDbContext, IApiExecutionContext apiExecutionContext) : base(liteDbContext, apiExecutionContext)
    {
    }
}
