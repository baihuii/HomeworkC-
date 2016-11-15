using System;

namespace MaximalSequence
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int biggestSeq = 0;
            int count = 1;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > biggestSeq)
                {
                    biggestSeq = count;
                }

            }
            Console.WriteLine(biggestSeq);

        }
    }
}

