using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Antlr4.Next
{
    public interface IParser
    {
        void AddErrorListener(IAntlrErrorListener<IToken> listener);
        void AddParseListener([NotNull] IParseTreeListener listener);
    }
}
