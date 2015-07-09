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
        public static double Root(double x, double degree, double precision)
        {
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
