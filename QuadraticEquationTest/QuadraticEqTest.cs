using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using QuadraticEquation;
namespace QuadraticEquationTest
{
    public class QuadraticEqTest
    {
        [Fact]
        public void ValidInputTest()
        {
            
            Assert.Throws<FormatException>(() => QuadraticEquation.Program.AcceptInput("2","a","1"));
        }
        [Theory]
        [InlineData(1,-2,1)]
        [InlineData(1,-4,4)]
        public void IsPerfectSquareTest(double A,double B,double C)
        {
            bool expected = true;
            var equation = new QuadraticEq(A,B,C);
            var actual=equation.IsPerfectSquare();
            Assert.Equal(expected,actual);
        }

    }
}
