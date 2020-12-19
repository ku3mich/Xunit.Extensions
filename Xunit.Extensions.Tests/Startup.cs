// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.Hosting;
using Xunit.Extensions.Essentials;

namespace Xunit.Extensions.Tests
{
    public class Startup
    {
        public void ConfigureHost(IHostBuilder hostBuilder) =>
            hostBuilder.ConfigureXunitEssentials();
    }
}
