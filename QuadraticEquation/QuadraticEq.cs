using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    public class QuadraticEq
    {

        
        

        private double coefficient1;//coefficient of x-square
        private double coefficient2;//coefficient of x
        private double constant;//constant

        public QuadraticEq(double coefficient1,double coefficient2,double constant)
        {
            this.coefficient1 = coefficient1;
            this.coefficient2 = coefficient2;
            this.constant = constant;
        }
       public bool IsPerfectSquare()
        {
            
            //check if the quadratic function has 1 root;  B^2-(4*A*C)=0
            if (Math.Pow(coefficient2, 2) - (4 * coefficient1 * constant) == 0)
            {
                return true;
            }
            else
                return false;
        }
        public double SolvePerfectSquare()
        {
            
            double root1 = -coefficient2 /( 2 * coefficient1);
           
            return root1;
        }
        public List<double> SolvenonPerfectSquare()
        {
            List<double> root = new List<double>();
           double root1 = ((-coefficient2) + Math.Sqrt(Math.Pow(coefficient2, 2) - (4 * coefficient1 * constant))) / 2 * coefficient1;
           double root2 = ((-coefficient2) - Math.Sqrt(Math.Pow(coefficient2, 2) - (4 * coefficient1 * constant))) / 2 * coefficient1;
            root.Add(root1);
            root.Add(root2);

            return root;
        }
        public bool hasRoot()
        {
            if (Math.Pow(coefficient2, 2) - (4 * coefficient1 * constant) < 0)
            {
                return false;
            }
            else
                return true;

        }
        public void ShowRoot()
        {
            hasRoot();
            IsPerfectSquare();
            if (hasRoot())
            {
                if (IsPerfectSquare())
                {
                    
                    Console.WriteLine("The equation has 1 root : ");
                    Console.WriteLine(SolvePerfectSquare());
                }
                else
                {
                  List<double> result=  SolvenonPerfectSquare();
                    Console.WriteLine("The equation has 2 roots : ");
                    foreach(double x in result)
                        Console.WriteLine(x);
                }
            }
            else
                Console.WriteLine("There are no real roots for the equation.");
            
            }
    }
}
