// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.Logging;

namespace Xunit.Extensions.Tests
{
    public class CoreSimpleLoggerInjectionTests
    {
        private readonly ILogger Logger;

        public CoreSimpleLoggerInjectionTests(ILogger logger)
        {
            Logger = logger;
        }

        [Fact]
        public void Logging()
        {
            Logger.LogDebug("it works");
        }
    }
}
