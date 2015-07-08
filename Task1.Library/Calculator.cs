using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Library
{
    public static class Calculator
    {
        public static double Root(double x, double n, double precision)
        {
            double result = x;
            double next = x / n;
            while (Math.Abs(next - result) > precision)
            {
                result = next;
                next = (1 / n) * ((n - 1) * result + x / Math.Pow(result, n - 1));
            }
            return next;
        }
    }
}
