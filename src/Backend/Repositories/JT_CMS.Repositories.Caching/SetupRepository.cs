namespace JT_CMS.Repositories.Caching;

public class SetupRepository(ISetupRepository setupRepository, ICacheProvider cacheProvider) : ISetupRepository
{
    private static string CacheKey => $"{nameof(SetupRepository)}";

    public async Task<bool> Initialized(CancellationToken cancellationToken = default)
    {
        return await GetCached(cancellationToken);
    }

    public async Task<bool> InitializeDb(CancellationToken cancellationToken = default)
    {
        var result = await setupRepository.InitializeDb(cancellationToken);
        cacheProvider.Remove(CacheKey);
        return result;
    }

    private async Task<bool> GetCached(CancellationToken cancellationToken = default)
    {
        if (!cacheProvider.TryGetValue(CacheKey, out bool isInitiliazed) || !isInitiliazed)
        {
            isInitiliazed = await setupRepository.Initialized(cancellationToken);
            if (isInitiliazed)
            {
                cacheProvider.Set(CacheKey, true);
            }
        }
        return isInitiliazed;
    }
}
