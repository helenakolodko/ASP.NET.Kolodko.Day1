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
                if (Double.TryParse(System.Console.ReadLine(), out x))
                {
                    double degree;
                    System.Console.Write("Degree [2]: ");
                    if (!Double.TryParse(System.Console.ReadLine(), out degree))
                        degree = 2;
                    double precision;
                    System.Console.Write("Precision [.01]: ");
                    if (!Double.TryParse(System.Console.ReadLine(), out precision))
                        degree = .01;

                    System.Console.WriteLine("Result of Calculator.Root method: " + Calculator.Root(x, degree, precision));
                    System.Console.WriteLine("Result of Math.Pow method: " + Math.Pow(x, 1 / degree));
                    System.Console.WriteLine();                                        
                }
            }
            System.Console.WriteLine(Calculator.Root(-9, 2, .0001));
        }
    }
}
