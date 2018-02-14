using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    /// <summary>
    /// Class containing Bubble Sort's algorithm implementation.
    /// </summary>
    class Bubble
    {
        /// <summary>
        /// This method implements Bubble Sort's main algorithm 
        /// </summary>
        /// <param name="arr">the given array to be sorted</param>
        public static int[] TypicalSort(int[] arr)
        {
            int count = arr.Length;

            for (int i = count - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int s = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = s;
                    }
                }
            }
            return arr;
        }
        
        /// <summary>
        /// Sort method wich implements Bubble Sort
        /// </summary>
        /// <param name="arr">The given array wich should be sorted</param>
        /// <returns>Returns sorted array</returns>
        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            sorted = Bubble.TypicalSort(sorted);
            return sorted;
        }
    }
}
