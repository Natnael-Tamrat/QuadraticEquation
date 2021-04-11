using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticEquation
{
    public class QuadraticEq
    {

        
        

        private double root1;
        private double root2;
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
        public void SolvePerfectSquare()
        {
            root1 = -coefficient2 /( 2 * coefficient1);
        }
        public void SolvenonPerfectSquare()
        {
            root1 = ((-coefficient2) + Math.Sqrt(Math.Pow(coefficient2, 2) - (4 * coefficient1 * constant))) / 2 * coefficient1;
            root2 = ((-coefficient2) - Math.Sqrt(Math.Pow(coefficient2, 2) - (4 * coefficient1 * constant))) / 2 * coefficient1;
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
                    SolvePerfectSquare();
                    Console.WriteLine("The equation has 1 root : " + root1);
                }
                else
                {
                    SolvenonPerfectSquare();
                    Console.WriteLine("The equation has 2 roots : " + root1 + " and " + root2);
                }
            }
            else
                Console.WriteLine("There are no real roots for the equation.");
            
            }
    }
}
