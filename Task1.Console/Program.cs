using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Library;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.Write("Radicant: ");
                double x;
                if (double.TryParse(System.Console.ReadLine(), out x))
                {
                    int degree;
                    System.Console.Write("Degree [2]: ");
                    if (!int.TryParse(System.Console.ReadLine(), out degree))
                        degree = 2;
                    double precision;
                    System.Console.Write("Precision [.01]: ");
                    if (!double.TryParse(System.Console.ReadLine(), out precision))
                        precision = .01;

                    System.Console.WriteLine("Result of Calculator.Root method: " + Calculator.NewtonRoot(x, degree, precision));
                    System.Console.WriteLine("Result of Math.Pow method: " + Math.Pow(x, 1d / degree));
                    System.Console.WriteLine();                                        
                }
            }
        }
    }
}
