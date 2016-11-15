using System;

namespace MaximalIncreasingSequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int biggestIncSeq = 0;
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > biggestIncSeq)
                {
                    biggestIncSeq = count;
                }

            }
            Console.WriteLine(biggestIncSeq);
        }
    }
}
