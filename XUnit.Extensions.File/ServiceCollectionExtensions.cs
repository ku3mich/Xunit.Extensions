using Microsoft.Extensions.DependencyInjection;

namespace XUnit.Extensions.File
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXUnitFileExtensioins(this IServiceCollection services)
        {
            services.AddSingleton<IDiff>(new Diff());
            return services;
        }
    }
}
