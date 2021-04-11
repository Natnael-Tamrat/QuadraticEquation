using System;

namespace QuadraticEquation
{
   public class Program
    {
        
        public static void AcceptInput(String A,String B,String C)
        {
            double coefficient1;
            double coefficient2;
            double constant;



            bool flag1 = double.TryParse(A, out coefficient1);
            bool flag2 = double.TryParse(B, out coefficient2);
            bool flag3 = double.TryParse(C, out constant);

            if (flag1 && flag2 && flag3)
            {
                QuadraticEq equation = new QuadraticEq(coefficient1, coefficient2, constant);
                equation.ShowRoot();
            }
            else
                throw new FormatException("Argument not in a correct format");
            
          
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arrange the equation Ax^2+Bx+C = 0");
            Console.WriteLine("Enter the coefficient of x-square (A)");
            string A = Console.ReadLine();
            Console.WriteLine("Enter the coefficient of x (B)");
            string B = Console.ReadLine();
            Console.WriteLine("Enter the Constant (C)");
            string C = Console.ReadLine();

            AcceptInput(A,B,C);
          }
    }
}
