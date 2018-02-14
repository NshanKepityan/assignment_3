using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Bubble
    {
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
        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            sorted = Bubble.TypicalSort(sorted);
            return sorted;
        }
    }
}
