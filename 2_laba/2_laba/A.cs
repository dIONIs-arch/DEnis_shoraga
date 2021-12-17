using System;
using System.Collections.Generic;
using System.Text;

namespace _2_laba
{
    class A
    {
        protected double x1;

        public double linear_equation(double a, double b)
        {
            if (a == 0)
                throw new Exception("Нет корней");
            else
                return x1 = -b / a;
        }
    }
}
