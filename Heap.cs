using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    /// <summary>
    /// Class containing Heap Sort algorithm implementation.
    /// </summary>
    public class Heap
    {
        public static void SiftDown(int[] arr, int firstIndex, int lastIndex)
        {
            int temp;
            int left = 2 * firstIndex;      
            int right = 2 * firstIndex + 1; 
            int maxIndex = firstIndex;

            if (right <= lastIndex && arr[right] > arr[maxIndex])
                maxIndex = right;
            else if (left <= lastIndex && arr[left] > arr[maxIndex])
                maxIndex = left;

            if (maxIndex != firstIndex)
            {
                temp = arr[firstIndex];
                arr[firstIndex] = arr[maxIndex];
                arr[maxIndex] = temp;

                SiftDown(arr, maxIndex, lastIndex);
            }
        }

        public static void CreateHeap(int[] arr, int lastIndex)
        {
            for (int i = lastIndex / 2; i >= 0; i--)
            {
                SiftDown(arr, i, lastIndex);
            }
        }

        public static void TypicalSort(int[] arr, int lastIndex)
        {
            CreateHeap(arr, lastIndex);
            int temp;
            int other = lastIndex;
            while (other >= 1)
            {
                temp = arr[0];
                arr[0] = arr[other];
                arr[other] = temp;
                other--;
                SiftDown(arr, 0, other);
            }
        }

        public static int[] Sort(int[] arr)
        {
            TypicalSort(arr, arr.Length - 1);
            return arr;
        }
    }
}