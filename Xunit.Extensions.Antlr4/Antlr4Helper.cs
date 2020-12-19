// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Microsoft.Extensions.Logging;

namespace Xunit.Extensions.Antlr4
{
    public class Antlr4Helper<TLexer, TParser>
        where TParser : Parser
        where TLexer : Lexer
    {
        private readonly ILogger Logger;
        private readonly IEnumerable<Func<IParseTreeListener>> ListnersFactory;
        private readonly Func<IAntlrErrorListener<IToken>> ErrorListnerFactory;

        public Antlr4Helper(ILogger logger) : this(
            logger,
            new Func<IParseTreeListener>[] { () => new DebugListener(logger) }, null)
        {
        }

        public Antlr4Helper(ILogger logger,
            IEnumerable<Func<IParseTreeListener>> listnersFactory,
            Func<IAntlrErrorListener<IToken>> errorListnerFactory)
        {
            Logger = logger;
            ListnersFactory = listnersFactory;
            ErrorListnerFactory = errorListnerFactory;
        }

        public ITokenStream CreateStream(string text)
        {
            Logger.LogDebug(text);
            TLexer lexer = CreateLexer(text);
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);
            tokenStream.Fill();

            Logger.LogDebug(
                string.Join(" -> ",
                    tokenStream.GetTokens()
                    .Select(s => new
                    {
                        s.Channel,
                        Token = lexer.Vocabulary.GetDisplayName(s.Type)
                    })
                    .Select(s => $"[{s.Token}:{s.Channel}]")));

            return tokenStream;
        }

        public TParser CreateParser(string s) =>
            CreateParser(CreateStream(s));

        public TParser CreateParser(ITokenStream s)
        {
            TParser parser = (TParser)Activator.CreateInstance(typeof(TParser), s);

            if (ListnersFactory != null)
            {
                foreach (Func<IParseTreeListener> listnerFactory in ListnersFactory)
                    parser.AddParseListener(listnerFactory());
            }

            if (ErrorListnerFactory != null)
                parser.AddErrorListener(ErrorListnerFactory());

            return parser;
        }

        public static TLexer CreateLexer(string input) =>
            (TLexer)Activator.CreateInstance(typeof(TLexer), new AntlrInputStream(input));
    }
}
