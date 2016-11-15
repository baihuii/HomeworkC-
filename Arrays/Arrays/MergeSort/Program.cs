﻿using System;

namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // In each iteration sort blocks with (2^(iteration-1)) length, e.g. 1, 2, 4 etc.  
            for (int iteration = 1; iteration < arr.Length; iteration *= 2)
            {
                int[] result = new int[arr.Length];

                // Fills result with sorted iteration-long blocks
                // At first iteration sorts {(2 with 1), (8 with 0), ...}
                for (int leftStart = 0; leftStart < arr.Length; leftStart += 2 * iteration)
                {
                    int rightStart = Math.Min(leftStart + iteration, arr.Length);
                    int rightEnd = Math.Min(leftStart + (2 * iteration), arr.Length);
                    MergeSortedPartsOfArray(arr, leftStart, rightStart, rightEnd, result);
                }

                // arr takes sorted result each time
                // At the end of first iteration: {(1, 2), (0, 8), (1, 3), (-5, 7), 15},
                // at the end of second iteration: {(0, 1, 2, 8), (-5, 1, 3, 7), 15} etc.
                arr = result;
            }

            // Print result
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private static void MergeSortedPartsOfArray(
            int[] arr1,
            int leftStart,
            int rightStart,
            int rightEnd,
            int[] result)
        {
            int resultIndex;
            int leftEnd = rightStart - 1;

            for (resultIndex = leftStart; resultIndex < rightEnd; resultIndex++)
            {
                if (leftStart <= leftEnd &&
                    (rightStart >= rightEnd || arr1[leftStart] <= arr1[rightStart]))
                {
                    result[resultIndex] = arr1[leftStart];
                    leftStart++;
                }
                else
                {
                    result[resultIndex] = arr1[rightStart];
                    rightStart++;
                }
            }
        }
    }
}
