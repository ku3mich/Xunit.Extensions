// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;
using System.IO;

namespace Xunit.Extensions.Tests
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
            string p = typeof(CoreTests).Assembly.Location;
            string t = Path.GetDirectoryName(p);
            Assert.Equal(t, PathResolver.Instance.Resolve(""));
        }

        [Fact]
        public void PathResolverFailsForAbsolutePaths()
        {
            Assert.Throws<ArgumentException>(() => PathResolver.Instance.Resolve("/"));
        }
    }
}
