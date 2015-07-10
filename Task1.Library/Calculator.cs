using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public static class Calculator
    {
        /// <summary>
        /// Calculates a nth root of a number
        /// </summary>
        /// <param name="x">Radicand</param>
        /// <param name="degree">Degree of the root</param>
        /// <param name="precision">Precision of the result</param>
        /// <returns>Root of the given degree</returns>
        /// <exception cref="ArgumentException">Thrown when <see cref="degree"/> is zero, or <see cref="x"/> is negative and <see cref="degree"/> is an even number.</exception>
        public static double NewtonRoot(double x, int degree, double precision)
        {
            if (degree == 0)
            {
                throw new ArgumentException("Can't calculate root of zero degree.", "degree");
            }
            if (x < 0 && degree % 2 == 0)
            {
                throw new ArgumentException("Can't calculate an even degree root of a negative number.", "degree");
            }            
            precision = Math.Abs(precision);
            double result = 1;
            double delta = (1 / degree) * (x / Math.Pow(result, degree - 1) - result);
            while (Math.Abs(delta) > precision)
            {
                result += delta;
                delta = (1 / degree) * (x / Math.Pow(result, degree - 1) - result);
            }
            return result + delta;
        }
    }
}
