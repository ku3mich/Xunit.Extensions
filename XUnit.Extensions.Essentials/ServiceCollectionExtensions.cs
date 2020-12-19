// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xunit.Extensions.Core;
using Xunit.Extensions.File;
using Xunit.Extensions.Logger;

namespace Xunit.Extensions.Essentials
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXunitEssentials(this IServiceCollection services, HostBuilderContext hostContext)
        {
            services
                .AddXunitCoreExtensions()
                .AddXunitLogger(hostContext.Configuration)
                .AddXunitFileExtensioins();

            return services;
        }
    }
}
