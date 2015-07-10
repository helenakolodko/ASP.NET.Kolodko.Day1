using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Library
{
    public static class IntMatrixSorter
    {
        /// <summary>
        /// Sort matrix by maximal elements of matrix's rows.
        /// </summary>
        /// <param name="array">Matrix to be sorted.</param>
        /// <param name="increasing">Specifies the order of sorting.</param>
        public static void SortByMaxRowElement(int[][] array, bool increasing = true)
        {
            SortRows(array, CompareByMaxElement, increasing);
        }

        /// <summary>
        /// Sort matrix by minimal elements of matrix's rows.
        /// </summary>
        /// <param name="array">Matrix to be sorted.</param>
        /// <param name="increasing">Specifies the order of sorting.</param>
        public static void SortByMinRowElement(int[][] array, bool increasing = true)
        {
            SortRows(array, CompareByMinElement, increasing);
        }

        /// <summary>
        /// Sort matrix by elements sum of matrix's rows.
        /// </summary>
        /// <param name="array">Matrix to be sorted.</param>
        /// <param name="increasing">Specifies the order of sorting.</param>
        public static void SortBySumOfRowElements(int[][] array, bool increasing = true)
        {
            SortRows(array, CompareBySumOfElements, increasing);
        }

        /// <summary>
        /// Sort matrix rows using specified compare method.
        /// </summary>
        /// <param name="array">Matrix to be sorted.</param>
        /// <param name="compareMethod">Method that compares two arrays and returns positive number if the first is greater, zero if equals and negative if smaller.</param>
        /// <param name="increasing">Specifies the order of sorting.</param>
        public static void SortRows(int[][] array, Func<int[], int[], int> compareMethod, bool increasing = true)
        {
            int i = 1;
            bool found = true;

            while (i < array.Length && found)
            {
                found = false;
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (compareMethod(array[j - 1], array[j]) > 0 == increasing)
                    {
                        SwapElements(array, j);
                    }
                    found = true;
                }
                i++;
            }
        }

        private static void SwapElements(int[][] array, int i, int j)
        {
            int[] temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }

        private static int CompareByMaxElement(int[] a, int[] b)
        {
            int firstMax = GetMaxElement(a);
            int secondMax = GetMaxElement(b);
            return firstMax.CompareTo(secondMax);
        }

        private static int GetMaxElement(int[] array)
        {
            int max = int.MinValue;
            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        private static int CompareByMinElement(int[] a, int[] b)
        {
            int firstMin = GetMinElement(a);
            int secondMin = GetMinElement(b);
            return firstMin.CompareTo(secondMin);
        }

        private static int GetMinElement(int[] array)
        {
            int min = int.MaxValue;
            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        private static int CompareBySumOfElements(int[] a, int[] b)
        {
            int firstSum = GetSumOfElements(a);
            int secondSum = GetSumOfElements(b);
            return firstSum.CompareTo(secondSum);
        }

        private static int GetSumOfElements(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
    }
}
