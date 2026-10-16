using Microsoft.AspNetCore.Identity;

namespace JT_CMS.Identity;

public partial class UserStore(IUserRepository repository) : IProtectedUserStore<User>
{

}
