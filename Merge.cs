using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    /// <summary>
    /// Class containing Merge Sort algorithm implementation.
    /// </summary>
    class Merge
    {
        /// <summary>
        /// Merges two subarray.
        /// </summary>
        /// <param name="arr">The given array to be sorted.</param>
        /// <param name="firstIndex">The first index of an array.</param>
        /// <param name="middleIndex">The middle index of an array.</param>
        /// <param name="lastindex">The last index of an array.</param>
        public static void MergeArrays(int[] arr, int firstIndex, int middleIndex, int lastIndex)
        {
            int i1 = firstIndex;
            int i2 = middleIndex + 1;
            int k = 0, j, i;
            int[] secondArr = new int[lastIndex - firstIndex + 1]; 

            for (j = firstIndex; j <= lastIndex; j++)
            {
                if (i1 > middleIndex)
                    secondArr[k++] = arr[i2++];

                else if (i2 > lastIndex)
                    secondArr[k++] = arr[i1++];

                else if (array[i1] < arr[i2])
                    secondArr[k++] = arr[i1++];
                
                else
                    secondArr[k++] = arr[i2++];
            }

            for (i = 0; i < k; i++)
            {
                array[firstIndex++] = secondArr[i];
            }
        }


        /// <summary>
        /// The basic method which implements the Merge Sort algorithm.
        /// </summary>
        /// <param name="arr">The given array to be sorted.</param>
        /// <param name="firstIndex">The first index of an array.</param>
        /// <param name="lastIndex">The last index of an array.</param>
        public static void TypicalSort(int[] arr, int firstIndex, int lastIndex)

        {
            if (firstIndex < lastIndex)
            {
                int midleIndex = (firstIndex + lastIndex) / 2;
                TypicalSort(arr, firstIndex, midleIndex);
                TypicalSort(arr, midleIndex + 1, lastIndex);
                MergeArrays(arr, firstIndex, midleIndex, lastIndex);
            }
        }
        /// <summary>
        /// Sort method wich implements Merge Sort
        /// </summary>
        /// <param name="arr">The givent array wich should be sorted</param>
        /// <returns>Returns sorted array</returns>
        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            TypicalSort(arr, 0, arr.Length - 1);
            return sorted;
        }
    }
}

