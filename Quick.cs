using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick
{
    /// <summary>
    /// Class containing Quick Sort algorithm implementation.
    /// </summary>
    class Quick
    {
        /// <summary>
        /// This method implements Quick Sort's main algorithm 
        /// </summary>
        /// <param name="arr">the givent array to be sorted</param>
        public static void TypicalSort(int[] arr, int l, int r)
        {
            int i=l, j=r;
            int x = arr[(l + r) / 2];
            while (true)
            {
                while (arr[i] < x)
                    i++;
                while (x < arr[j])
                    j--;
                if (i <= j)
                {
                    int s = arr[i];
                    arr[i] = arr[j];
                    arr[j] = s;
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                TypicalSort(arr, l, j);
            if (i < r)
                TypicalSort(arr, i, r);
        }
        
        /// <summary>
        /// Sort method wich implements Quick Sort
        /// </summary>
        /// <param name="arr">The givent array wich should be sorted</param>
        /// <returns>Returns sorted array</returns>
        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            TypicalSort(sorted, 0, sorted.Length - 1);
            return sorted;
        }
    }
}
