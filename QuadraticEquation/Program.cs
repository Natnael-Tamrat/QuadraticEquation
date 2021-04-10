using System;

namespace QuadraticEquation
{
    class Program
    {
        private static double A;
        private static double B;
        private static double C;

        static void Main(string[] args)
        {
            Console.WriteLine("Arrange the equation Ax^2+Bx+C = 0");
            try
            {
                Console.WriteLine("Enter the coefficient of x-square (A)");
                A = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the coefficient of x (B)");
                B = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Constant (C)");
                C = double.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter number only");
            }
            QuadraticEq equation = new QuadraticEq(A, B, C);
            equation.ShowRoot();
        }
    }
}
