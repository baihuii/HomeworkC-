using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int value = int.Parse(Console.ReadLine());
            int low = 0;
            int high = n - 1;
            int mid = -1;
            int index = -1;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (arr[mid] > value)
                {
                    high = mid - 1;
                }
                else if (arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    index = mid;
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}