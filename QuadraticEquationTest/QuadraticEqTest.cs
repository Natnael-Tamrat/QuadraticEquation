using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using QuadraticEquation;
using System.Collections.Generic;

namespace QuadraticEquationTest
{
    public class QuadraticEqTest
    {
        [Theory]
        [InlineData("a","1","2")]
        [InlineData("1", "a", "2")]
        [InlineData("1", "1", "a")]

        public void InvalidInputTest(string A,string B,string C)
        {
            //this test check whether format exception is thrown if non numeric value is entered by the user
            Assert.Throws<FormatException>(() => QuadraticEquation.Program.AcceptInput(A,B,C));
        }
        
        [Fact]
        public void QuadraticCoefficientTest()
        {
            //this test check if exception is thrown when the user enter 0 on the coefficient of x-square
            Assert.Throws<Exception>(() => QuadraticEquation.Program.AcceptInput("0","1","2"));
        }

        [Theory]
        [InlineData(true, 1, -2, 1)]
        [InlineData(false, 1, -3, 4)]
       public void hasRootTest(bool expected,double A,double B,double C)
        {
            //this test check if the quadratic equation has root or no real root , identify those who have no real roots
            var equation = new QuadraticEq(A, B, C);
            var actual = equation.hasRoot();
            Assert.Equal(expected, actual);

        }
        
        
        [Theory]
        [InlineData(true,1,-2,1)]
        [InlineData(true,1,-4,4)]
        [InlineData(false,1,-5,6)]
        public void IsPerfectSquareTest(bool expected,double A,double B,double C)
        {
            //this test check perfect square where discrimnant of the equation is 0 and has only one real root
            var equation = new QuadraticEq(A,B,C);
            var actual=equation.IsPerfectSquare();
            Assert.Equal(expected,actual);
        }
       [Theory]
       [InlineData(1,1,-2,1)]
       [InlineData(2,1,-4,4)]
        public void SolvePerfectSquareTest(double expected,double A,double B,double C)
        {
            //test for solving perfect squares
            var equation = new QuadraticEq(A, B, C);
            double actual = equation.SolvePerfectSquare();

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(2,3, 1, -5, 6)]
        [InlineData(1, 2, 1, -3, 2)]
        public void SolveNonPerfectSquareTest(double expectedroot1,double expectedroot2, double A, double B, double C)
        {
            //test for solving non perfect squares
            List<double> results = new List<double>();
            results.Add(expectedroot2);
            results.Add(expectedroot1);
            var equation = new QuadraticEq(A,B,C);
            Assert.Equal(results,equation.SolvenonPerfectSquare());
        }
    }
}
