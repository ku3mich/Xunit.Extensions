using System.Linq;
using Text.Diff;
using Xunit;
using Xunit.Abstractions;

namespace XUnit.Extensions.Tests
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
            var result = Diff.Generate("asd", "asd");
            Console.WriteLine(result);
            Assert.Equal("  asd |   asd\n", result);
        }

        [Fact]
        public void AddedLine()
        {
            var result = Diff.Generate("asd\nqwe", "asd");
            Console.WriteLine(result);
            Assert.Equal("  asd |   asd\n- qwe |   \n", result);
        }

        [Fact]
        public void ChangedSymbol()
        {
            var result = Diff.Generate("asQWE rt", "asqwe rt");
            Console.WriteLine(result);
            Assert.Equal("~ asQWE rt | ~ asqwe rt\n    ~~~    |     ~~~\n", result);
        }

        [Fact]
        public void DeletedSymbol()
        {
            var result = Diff.Generate("hello", "helo");
            Console.WriteLine(result);
            Assert.Equal("~ hello | ~ helo\n     -  |   \n", result);
        }

        [Fact]
        public void AddedSymbol()
        {
            var result = Diff.Generate("helo", "hello");
            Console.WriteLine(result);
            Assert.Equal("~ helo | ~ hello\n       |      +\n", result);
        }
    }
}
