using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 5, 4, 3, 2, 1, 0 };
            QuickSort.QuickSorting(arr, 0, arr.Length - 1);
            foreach (var num in arr)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("The elements are sorted using Quicksort method");
            int[] arr2 = { 2, 4,  6, 8, 5, 3, 7 };
            MergeSort.mergeSort(arr2);
            foreach (var num in arr2)
            {
                Console.Write($"{num}, ");
            }
            Console.WriteLine("The elements are sorted using Mergesort method");

        }
    }
}
