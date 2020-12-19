// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace Antlr4.Next
{
    public class SyntaxErrorThrower : BaseErrorListener
    {
        public override void SyntaxError(
            [NotNull] IRecognizer recognizer,
            [Nullable] IToken offendingSymbol,
            int line,
            int charPositionInLine,
            [NotNull] string msg,
            [Nullable] RecognitionException e)
        {
            throw new SyntaxErrorException($"syntax error at {line}:{charPositionInLine} = {msg}", e);
        }
    }
}
