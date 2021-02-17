using System;

namespace Lab1Alexey {
    class Program {
        static void Main(string[] args) {
            int[] arr1 = new int[] {1, 5, 4, 11, 20, 8, 2, 98, 90, 16};
            int[] arr2 = new int[10];
            
            Array.Copy(arr1,arr2, arr1.Length);
            
            MergeSorting.MergeSort(arr1, 0, arr1.Length - 1);
            Console.WriteLine("Merge sort:");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
            
            QuickSort.sort(arr2, 0, arr2.Length - 1);
            Console.WriteLine("Quick sort:");
            for (int i = 0; i < arr2.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Index of given key is " + 
                              BinarySearch.BinarySearchRecursive(arr2, 20, 0, arr2.Length));
        }
    }
}