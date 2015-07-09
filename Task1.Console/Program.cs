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
            System.Console.WriteLine(Calculator.Root(-9, 2, .0001));
        }
    }
}
