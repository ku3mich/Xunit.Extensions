// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Antlr4.Runtime;

namespace Antlr4
{
    public abstract class Parser : Runtime.Parser, IParser
    {
        protected Parser(ITokenStream input) : base(input)
        {
        }
    }
}
