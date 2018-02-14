using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge
{
    class Merge
    {
        public static void MergeArrays(int[] array, int firstIndex, int middleIndex, int lastindex)

        {

            int index1 = firstIndex, index2 = middleIndex + 1;
            int k = 0, j, i;
            int[] secondArray = new int[lastindex - firstIndex + 1]; 


            for (j = firstIndex; j <= lastindex; j++)
            {
                if (index1 > middleIndex)
                    secondArray[k++] = array[index2++];

                else if (index2 > lastindex)
                    secondArray[k++] = array[index1++];

                else if (array[index1] < array[index2])
                    secondArray[k++] = array[index1++];


                else
                    secondArray[k++] = array[index2++];
            }

            for (i = 0; i < k; i++)

            {
                array[firstIndex++] = secondArray[i];
            }

        }



        public static void TypicalSort(int[] a, int firstIndex, int lastIndex)

        {

            if (firstIndex < lastIndex)

            {
                int midleIndex = (firstIndex + lastIndex) / 2;
                TypicalSort(a, firstIndex, midleIndex);
                TypicalSort(a, midleIndex + 1, lastIndex);
                MergeArrays(a, firstIndex, midleIndex, lastIndex);

            }

        }
        public static int[] Sort(int[] arr)

        {
            int[] sorted = arr;
            TypicalSort(arr, 0, arr.Length - 1);
            return sorted;
        }


    }
}

