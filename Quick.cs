using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick
{
    class Quick
    {
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

        public static int[] Sort(int[] arr)
        {
            int[] sorted = arr;
            TypicalSort(sorted, 0, sorted.Length - 1);
            return sorted;
        }
    }
}
