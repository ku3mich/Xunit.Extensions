using Microsoft.Extensions.DependencyInjection;
using Text.Diff;
using Xunit;

namespace XUnit.Extensions.File
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXUnitFileExtensioins(this IServiceCollection services)
        {
            services.AddSingleton<ITextDiff>(new TextDiff());
            return services;
        }
    }
}
