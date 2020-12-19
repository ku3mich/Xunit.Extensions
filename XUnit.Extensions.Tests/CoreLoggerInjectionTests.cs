// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace Xunit.Extensions.Tests
{
    public class CoreLoggerInjectionTests : XunitTest
    {
        private readonly ILogger<CoreLoggerInjectionTests> Logger;

        public CoreLoggerInjectionTests(
            ILogger<CoreLoggerInjectionTests> logger,
            ITestOutputHelper h) : base(h)
        {
            Logger = logger;
        }

        [Fact]
        public void Logging()
        {
            Logger.LogDebug("it works typed");
            Debug.Write("t debug");
            Trace.Write("t trace");
        }
    }
}
