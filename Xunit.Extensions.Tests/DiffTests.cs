// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Text.Diff;
using Xunit.Abstractions;

namespace Xunit.Extensions.Tests
{
    public class DiffTests
    {
        private readonly ITestOutputHelper Console;
        private ITextDiff Diff;

        public DiffTests(ITestOutputHelper console, ITextDiff diff)
        {
            Console = console;
            Diff = diff;
        }

        [Fact]
        public void UnchangedLine()
        {
            string result = Diff.Generate("asd", "asd");
            Console.WriteLine(result);
            Assert.Equal("  asd |   asd\n", result);
        }

        [Fact]
        public void AddedLine()
        {
            string result = Diff.Generate("asd\nqwe", "asd");
            Console.WriteLine(result);
            Assert.Equal("  asd |   asd\n- qwe |   \n", result);
        }

        [Fact]
        public void ChangedSymbol()
        {
            string result = Diff.Generate("asQWE rt", "asqwe rt");
            Console.WriteLine(result);
            Assert.Equal("~ asQWE rt | ~ asqwe rt\n    ~~~    |     ~~~\n", result);
        }

        [Fact]
        public void DeletedSymbol()
        {
            string result = Diff.Generate("hello", "helo");
            Console.WriteLine(result);
            Assert.Equal("~ hello | ~ helo\n     -  |   \n", result);
        }

        [Fact]
        public void AddedSymbol()
        {
            string result = Diff.Generate("helo", "hello");
            Console.WriteLine(result);
            Assert.Equal("~ helo | ~ hello\n       |      +\n", result);
        }
    }
}
