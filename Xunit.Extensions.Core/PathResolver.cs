// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using System;
using System.IO;

namespace Xunit
{
    public class PathResolver : IPathResolver
    {
        public static IPathResolver Instance = new PathResolver();

        private readonly string Root;

        public PathResolver() : this(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)) { }

        public PathResolver(string root)
        {
            Root = root;
        }

        public string Resolve(string relative = null)
        {
            string p = relative ?? string.Empty;
            if (Path.IsPathRooted(p))
                throw new ArgumentException("path should be relative path");

            // TODO: check outside the root 
            return Path.Combine(Root, p);
        }
    }
}
