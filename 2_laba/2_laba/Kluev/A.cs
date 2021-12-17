using System;
using System.Collections.Generic;
using System.Text;

namespace _2_laba
{
    class A
    {
        protected List<float> x1;

        public List<float> linear_equation(float a, float b)
        {
            if (a == 0)
                return null;

            return x1 = new List<float>() { -b / a };
        }
    }
}
