// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Xunit.Abstractions;

namespace Xunit.Extensions.Antlr4.Tests
{

    public class SampleTest : XunitTest
    {
        private readonly SampleHelper Helper;

        public SampleTest(SampleHelper helper, ITestOutputHelper h) : base(h)
        {
            Helper = helper;
        }

        [Fact]
        public void DebugWorks()
        {
            Helper.CreateParser("ABC").ruleA();
        }
    }
}
