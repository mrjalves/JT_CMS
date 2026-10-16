using Microsoft.AspNetCore.Identity;

namespace JT_CMS.Identity;

public partial class UserStore : IUserAuthenticatorKeyStore<User>
{
    public Task<string?> GetAuthenticatorKeyAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user?.AuthenticatorKey);
    }

    public Task SetAuthenticatorKeyAsync(User user, string key, CancellationToken cancellationToken)
    {
        user.AuthenticatorKey = key;
        return Task.CompletedTask;
    }
}
