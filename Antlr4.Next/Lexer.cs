using Antlr4.Runtime;

namespace Antlr4.Next
{
    public abstract class Lexer : Runtime.Lexer, ILexer
    {
        protected Lexer(ICharStream input) : base(input)
        {
        }

    }
}
