using System;
using System.Collections.Generic;
using System.Text;

namespace _2_laba
{
    class B : A
    {
        private double x2;

        protected double getDiscriminant(double a, double b, double c)
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }

        protected double[] Function(int a, int b, int c)
        {
            if (a == 0)
            {
                x1 = linear_equation(b, c);
                return new double[] { x1 };
            }







            double disc = getDiscriminant(a, b, c);

            if (disc == 0)
            {
                x1 = (-b) / 2 * a;
                return new double[] { x1 };
            }
            else if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / 2 * a;
                x2 = (-b - Math.Sqrt(disc)) / 2 * a;
            }
            else
            {
                throw new Exception("Корней нет.");
            }
            return new double[] { x1, x2 };
        }
    }
}
