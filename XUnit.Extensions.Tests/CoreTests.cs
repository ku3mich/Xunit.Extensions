using System;
using System.IO;
using Xunit;

namespace XUnit.Extensions.Tests
{
    public class CoreTests
    {
        [Theory]
        [FileContent("sample/hello.txt")]
        public void FileContent(string text)
        {
            Assert.Equal("hello world", text);
        }

        [Fact]
        public void PathResolverResolves()
        {
            var p = typeof(CoreTests).Assembly.Location;
            var t = Path.GetDirectoryName(p);
            Assert.Equal(t, PathResolver.Instance.Resolve(""));
        }

        [Fact]
        public void PathResolverFailsForAbsolutePaths()
        {
            Assert.Throws<ArgumentException>(() => PathResolver.Instance.Resolve("/"));
        }
    }
}
