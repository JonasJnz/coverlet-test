using SomeStuff;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SomeClassToBeTested s = new SomeClassToBeTested();
            Assert.True(s.Hello(100));
        }
    }
}
