using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class QuickSort
    {
        public static void QuickSorting(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(arr, start, end);
                QuickSorting(arr, start, pivot - 1);
                QuickSorting(arr, pivot + 1, end);
            }
        }

        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int index = start;

            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    Swap(arr, i, index);
                    index++;
                }
            }
            Swap(arr, index, end);

            return index;
        }

        public static void Swap(int[] arr, int start, int end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }
    }
}
