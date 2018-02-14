using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion
{
    class Insertion
    {
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
        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            sorted = Insertion.Insert(sorted);
            return sorted;
        }
    }
}
