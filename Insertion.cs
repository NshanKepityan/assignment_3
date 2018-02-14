using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion
{
    /// <summary>
    /// Class containing Insertion Sort algorithm implementation.
    /// </summary>
    class Insertion
    {
        
        /// <summary>
        /// This method implements Insertion Sort's main algorithm 
        /// </summary>
        /// <param name="arr">the givent array to be sorted</param>
        public static int[] Insert(int[] arr)
        {
            int i, j;
            int count = arr.Length;

            for (i = 1; i < count; i++)
            {
                for (j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    int s = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = s;
                }
            }
            return arr;
        }
        
        /// <summary>
        /// Sort method wich implements Insertion Sort
        /// </summary>
        /// <param name="arr">The givent array wich should be sorted</param>
        /// <returns>Returns sorted array</returns>
        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            sorted = Insertion.Insert(sorted);
            return sorted;
        }
    }
}
