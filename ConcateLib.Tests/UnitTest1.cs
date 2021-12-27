using System;
using Xunit;
using ConcateLib;

namespace ConcateLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello World",MyConCate.Concatestring("Hello","World" ));
        }
    }
}
