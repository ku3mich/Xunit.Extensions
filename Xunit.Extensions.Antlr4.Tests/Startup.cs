// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Xunit.Extensions.Essentials;

namespace Xunit.Extensions.Antlr4.Tests
{
    public class Startup
    {
        public virtual void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder.ConfigureXunitEssentials()
            .ConfigureServices(s =>
            {
                s.AddTransient<SampleHelper>();
            });
    }
}
