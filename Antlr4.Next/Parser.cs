using Antlr4.Runtime;

namespace Antlr4.Next
{
    public abstract class Parser : Runtime.Parser, IParser
    {
        protected Parser(ITokenStream input) : base(input)
        {
        }
    }
}
