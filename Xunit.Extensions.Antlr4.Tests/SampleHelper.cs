// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Microsoft.Extensions.Logging;
using SampleNamespace;

namespace Xunit.Extensions.Antlr4.Tests
{
    public class SampleHelper : Antlr4Helper<SampleLexer, SampleParser>
    {
        public SampleHelper(ILogger logger) : base(logger)
        {
            logger.LogDebug("oops");
        }
    }
}
