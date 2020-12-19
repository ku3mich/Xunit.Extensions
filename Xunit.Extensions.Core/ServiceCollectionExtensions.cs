// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.DependencyInjection;

namespace Xunit.Extensions.Core
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXunitCoreExtensions(this IServiceCollection services)
        {
            services
                .AddSingleton(s => PathResolver.Instance);

            return services;
        }
    }
}
