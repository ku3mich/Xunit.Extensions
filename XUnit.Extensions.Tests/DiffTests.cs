using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace XUnit.Extensions.Tests
{
    public class DiffTests
    {
        private readonly ITestOutputHelper Console;
        private IDiff Diff;

        public DiffTests(ITestOutputHelper console, IDiff diff)
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
            Assert.Equal("  asd |   asd\n- qwe | # \n", result);
        }

        [Fact]
        public void ChangedSymbol()
        {
            var result = Diff.Generate("asQWE rt", "asqwe rt");
            Console.WriteLine(result);
            Assert.Equal("~ asQWE rt | ~ asqwe rt\n    ---    |     +++   \n", result);
        }

        [Fact]
        public void DeletedSymbol()
        {
            var result = Diff.Generate("hello", "helo");
            Console.WriteLine(result);
            Assert.Equal("~ hello | ~ helo\n     -  |       \n", result);
        }

        [Fact]
        public void AddedSymbol()
        {
            var result = Diff.Generate("helo", "hello");
            Console.WriteLine(result);
            Assert.Equal("~ helo | ~ hello\n       |      + \n", result);
        }

        [Fact]
        public void Incorrect_Piece_Count()
        {
            var result = Diff.Generate(
            "namespace NUnit.sample\r\n{\r\n    using Xunit;\r\n    public class TestClass\r\n    {\r\n        [Fact]\r\n        public void TestCase()\r\n        {\r\n        }\r\n    }\r\n}\r\n",
            "namespace NUnit.sample\r\n{\r\n    using Xun1it;\r\n    public class TestClass\r\n    {\r\n        [Fact]\r\n        public void TestCase()\r\n        {\r\n        }\r\n    }\r\n}\r\n");
            var max = result.Split("\n").Max(s => s.Length);
            
        }
    }
}
