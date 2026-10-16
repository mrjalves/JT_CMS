namespace JT_CMS.Repositories.EFCore;

public class RoleRepository(JT_CMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Role, RoleModel>(dbContext, mapper, apiExecutionContext), IRoleRepository;
