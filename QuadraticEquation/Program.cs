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
            try
            {
                if (flag1 && flag2 && flag3)
                {
                    try
                    {
                        if (coefficient1 == 0)
                            throw new Exception("Coefficient of X-square can't be zero");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        Environment.Exit(0);
                    }
                    QuadraticEq equation = new QuadraticEq(coefficient1, coefficient2, constant);
                    equation.ShowRoot();
                }
                else
                    throw new FormatException("Argument not in a correct format");
            }
            catch(FormatException f)
            {
                Console.WriteLine(f.Message);
                Environment.Exit(0);
            }
          
        }
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Type quit and enter to exit the program press any key and enter to continue");
                string input = Console.ReadLine();
                if (input == "quit")
                    break;

                Console.WriteLine("Arrange the equation Ax^2+Bx+C = 0");
                Console.WriteLine("Enter the coefficient of x-square (A)");
                string A = Console.ReadLine();
                Console.WriteLine("Enter the coefficient of x (B)");
                string B = Console.ReadLine();
                Console.WriteLine("Enter the Constant (C)");
                string C = Console.ReadLine();

                AcceptInput(A, B, C);
            }
          }
    }
}
