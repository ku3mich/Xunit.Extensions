using Microsoft.Extensions.DependencyInjection;

namespace XUnit.Extensions.Core
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXUnitCoreExtensions(this IServiceCollection services)
        {
            services.AddSingleton<IPathResolver>(s => PathResolver.Instance);
            return services;
        }
    }
}
