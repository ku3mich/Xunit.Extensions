// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.DependencyInjection;
using Text.Diff;

namespace Xunit.Extensions.File
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddXunitFileExtensioins(this IServiceCollection services)
        {
            services.AddSingleton<ITextDiff>(new TextDiff());
            return services;
        }
    }
}
