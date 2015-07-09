using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Library;

namespace Task2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arraySource = { new int[] { 1, 8, 3, 9, -9, 4 }, new int[] { }, new int[] { 8, 6, 1 }, new int[] { 8, 6, 1 } };
            System.Console.WriteLine("Initial array:");
            ShowJaggedArray(arraySource);
            
            int[][] tempArray = (int[][])arraySource.Clone();
            IntMatrixSorter.SortByMaxRowElement(tempArray);
            System.Console.WriteLine("Increasingly sorted by max element:");
            ShowJaggedArray(tempArray);

            tempArray = (int[][])arraySource.Clone();
            IntMatrixSorter.SortByMaxRowElement(tempArray, false);
            System.Console.WriteLine("Decreasingly sorted by max element:");
            ShowJaggedArray(tempArray);

            tempArray = (int[][])arraySource.Clone();
            IntMatrixSorter.SortByMinRowElement(tempArray);
            System.Console.WriteLine("Increasingly sorted by min element:");
            ShowJaggedArray(tempArray);

            tempArray = (int[][])arraySource.Clone();
            IntMatrixSorter.SortByMinRowElement(tempArray, false);
            System.Console.WriteLine("Decreasingly sorted by min element:");
            ShowJaggedArray(tempArray);

            tempArray = (int[][])arraySource.Clone();
            IntMatrixSorter.SortBySumOfRowElements(tempArray);
            System.Console.WriteLine("Increasingly sorted by sum of elements:");
            ShowJaggedArray(tempArray);

            tempArray = (int[][])arraySource.Clone();
            IntMatrixSorter.SortBySumOfRowElements(tempArray, false);
            System.Console.WriteLine("Decreasingly sorted by sum of elements:");
            ShowJaggedArray(tempArray);

            System.Console.ReadKey();
        }

        static void ShowJaggedArray(int[][] array)
        {
            System.Console.Write("{");
            foreach (int[] row in array)
            {
                System.Console.Write(" { ");
                foreach(int element in row)
                {
                    System.Console.Write(element + " ");
                }
                System.Console.Write("} ");
            }
            System.Console.WriteLine("}");

        }
    }
}
