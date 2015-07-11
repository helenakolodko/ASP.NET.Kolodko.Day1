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
        /// <exception cref="ArgumentException">Thrown when <see cref="degree"/> is negative number, or <see cref="x"/> is negative and <see cref="degree"/> is an even number.</exception>
        public static double NewtonRoot(double x, int degree, double precision)
        {
            if (degree < 0)
            {
                throw new ArgumentException("Can't calculate root of negative degree.", "degree");
            }
            if (x < 0 && degree % 2 == 0)
            {
                throw new ArgumentException("Can't calculate an even degree root of a negative number.", "degree");
            }            
            precision = Math.Abs(precision);
            double delta, result = 1;
            do
            {
                delta = (1d / degree) * (x / Math.Pow(result, degree - 1) - result);
                result += delta;
            }
            while (Math.Abs(delta) > precision);
            return result;
        }
    }
}
