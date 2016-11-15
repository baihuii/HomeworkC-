using System;

namespace SellectionSort
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];


            int temp;
            int lowerIntKey;
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arr.Length - 1; i += 1)
            {
                lowerIntKey = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[lowerIntKey])
                    {
                        lowerIntKey = j;
                    }
                }

                temp = arr[lowerIntKey];
                arr[lowerIntKey] = arr[i];
                arr[i] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}

