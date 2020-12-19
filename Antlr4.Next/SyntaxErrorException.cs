// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;

namespace Antlr4.Next
{
    public class SyntaxErrorException : Exception
    {
        public SyntaxErrorException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
