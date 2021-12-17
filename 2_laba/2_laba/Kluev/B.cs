using _2_laba.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_laba
{
    class B : A, EquationInterface
    {
        protected float getDiscriminant(float a, float b, float c)
        {
            return b * b - (4 * a * c);
        }

        public List<float> solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return linear_equation(b, c);
            }

            float D = getDiscriminant(a, b, c);

            if (D < 0)
            {
                return null;
            }

            if (D == 0)
                return x1 = new List<float>() { (-b) / (2 * a) };

            D = (float)Math.Sqrt(D);

            return x1 = new List<float>() {
                (-b + D) / (2 * a),
                (-b - D) / (2 * a)
            };
        }

       
    }
}
