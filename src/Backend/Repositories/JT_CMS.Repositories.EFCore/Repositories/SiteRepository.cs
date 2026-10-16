namespace JT_CMS.Repositories.EFCore;

public class SiteRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : AuditableEntityRepository<Site, SiteModel>(dbContext, mapper, apiExecutionContext), ISiteRepository
{
    public async Task<Site?> GetByUrl(string url, CancellationToken cancellationToken = default)
    {
        var dbEntity = await DbContext.Sites.Where(x => x.Urls.Contains(url)).SingleOrDefaultAsync(cancellationToken);
        return Mapper.Map<Site>(dbEntity);
    }
}
