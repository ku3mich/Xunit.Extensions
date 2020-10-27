using Microsoft.Extensions.DependencyInjection;
using XUnit.Extensions.Core;
using XUnit.Extensions.File;

namespace XUnit.Extensions.Essentials
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXUnitEssentials(this IServiceCollection services)
        {
            services
                .AddXUnitCoreExtensions()
                .AddXUnitFileExtensioins();

            return services;
        }
    }
}
