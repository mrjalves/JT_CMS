namespace JT_CMS.Repositories.EFCore;

public class FolderRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Folder, FolderModel>(dbContext, mapper, apiExecutionContext), IFolderRepository
{
    public async Task<Folder?> GetByName(Guid siteId, Guid? parentId, string normalizedName, CancellationToken cancellationToken = default)
    {
        var dbEntity = await DbContext.Folders.SingleOrDefaultAsync(x => x.SiteId == siteId && x.ParentId == parentId && x.NormalizedName == normalizedName, cancellationToken);
        return Mapper.Map<Folder>(dbEntity);
    }
}
