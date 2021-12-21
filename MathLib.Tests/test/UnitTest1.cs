using System;
using Xunit;
using MathLib;

namespace MathLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(8,Arithmetic.Add(3, 5));
        }
        //[Fact]
        //public void Test2()
        //{
        //    Assert.Equal(15, Arithmetic.Multiply(3, 5));
        //}
    }
}
