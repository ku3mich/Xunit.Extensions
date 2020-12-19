// Copyright (C) 2020 Serhii Kuzmychov (ku3mich@gmail.com)
// Licensed under the terms of the MIT license. See LICENCE for details.

using Xunit.Abstractions;

namespace Xunit
{
    public abstract class XunitTest : XunitContextBase
    {
        protected XunitTest(ITestOutputHelper output) : base(output, "source")
        {
        }
    }
}
