// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace Xunit.Extensions.Essentials
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder ConfigureXunitEssentials(this IHostBuilder hostBuilder) => hostBuilder
            .ConfigureHostConfiguration(builder =>
            {
                builder.SetBasePath(PathResolver.Instance.Resolve());
                builder.AddJsonFile("appsettings.json", optional: true);
            })
            .ConfigureServices((h, s) => s.AddXunitEssentials(h));
    }
}
