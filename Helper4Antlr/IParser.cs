// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace Antlr4
{
    public interface IParser
    {
        void AddErrorListener(IAntlrErrorListener<IToken> listener);
        void AddParseListener([NotNull] IParseTreeListener listener);
    }
}
