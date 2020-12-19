using Antlr4.Next;
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
