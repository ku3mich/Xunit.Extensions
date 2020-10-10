using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xunit.Sdk;

namespace XUnit
{
    public class FileContentAttribute : DataAttribute
    {
        private readonly string FileName;

        public FileContentAttribute(string fileName)
        {
            FileName = fileName;
        }

        public override IEnumerable<object[]> GetData(MethodInfo testMethod)
        {
            yield return new object[] {
                File.ReadAllText(PathResolver.Instance.Resolve(FileName))
            };
        }
    }
}
