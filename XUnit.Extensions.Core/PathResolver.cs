using System;
using System.IO;

namespace XUnit
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

        public string Resolve(string relative)
        {
            if (Path.IsPathRooted(relative))
                throw new ArgumentException("path should be relative path");

            // TODO: check outside the root 
            return Path.Combine(Root, relative);
        }
    }
}
