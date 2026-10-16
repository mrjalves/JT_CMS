using JT_CMS.Providers.TemplateRenderingProviders;
using JT_CMS.Providers.TemplateRenderingProviders.Abstractions;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceExtensions
{
    public static IServiceCollection AddScribanTemplateRenderingProvider(this IServiceCollection services)
    {
        services.AddScoped<ITemplateRenderingProvider, ScribanTemplateRenderingProvider>();
        return services;
    }
}
