using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit.Sdk;

namespace Xunit
{
    public class FileContentAttribute : DataAttribute
    {
        private readonly string[] FileNames;

        public FileContentAttribute(params string[] fileNames)
        {
            FileNames = fileNames;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            var prms = FileNames.Select(s => File.ReadAllText(PathResolver.Instance.Resolve(s))).Cast<object>().ToArray();
            yield return prms;
        }
    }
}
