// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Microsoft.Extensions.Logging;

namespace Xunit.Extensions.Antlr4
{
    public class DebugListener : IParseTreeListener
    {
        private readonly ILogger Logger;

        public DebugListener(ILogger logger)
        {
            Logger = logger;
        }

        int Indent = 0;

        protected void Output(string s, int indent)
        {
            Logger.LogDebug($"{new string(' ', indent)}{s}");
        }

        protected void IndentOuput(string s)
        {
            Output(s, Indent);
            Indent += 2;
        }
        protected void UnindentOuput(string s)
        {
            Indent -= 2;
            Output(s, Indent);
        }

        public void EnterEveryRule([NotNull] ParserRuleContext ctx)
        {
            IndentOuput($"{{ {ctx.GetType().Name}: @{ctx.Start?.Line}:{ctx.Start?.Column} ");
        }

        public void ExitEveryRule([NotNull] ParserRuleContext ctx)
        {
            UnindentOuput($"}} {ctx.GetType().Name} @{ctx.Stop?.Line}:{ctx.Stop?.Column} [{ctx.GetText()}]");
        }

        public void VisitErrorNode([NotNull] IErrorNode node)
        {
            /*
            var e = new System.Exception("* error");
            e.Data["node"] = node;
            // throw e;
            */
        }

        public void VisitTerminal([NotNull] ITerminalNode node)
        {
            // Method intentionally left empty.
        }
    }
}
