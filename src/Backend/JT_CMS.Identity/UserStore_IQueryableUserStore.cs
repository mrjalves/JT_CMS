using Microsoft.AspNetCore.Identity;

namespace JT_CMS.Identity;

public partial class UserStore : IQueryableUserStore<User>
{
    public IQueryable<User> Users => repository.AsQueryable();
}
