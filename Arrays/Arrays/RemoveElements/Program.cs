using System;

namespace RemoveElements
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int[] array = new int[count];

            int[] longestIncSeq = new int[count]; //longest increasing subsequence values

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                longestIncSeq[i] = 1;
            }

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[i] >= array[j] && longestIncSeq[i] <= longestIncSeq[j] + 1)
                    {
                        longestIncSeq[i] = longestIncSeq[j] + 1;
                    }

                }
            }
            for (int i = 0; i < longestIncSeq.Length; i++)
            {
                Console.WriteLine(longestIncSeq[i]);
            }
            Array.Sort(longestIncSeq);

            Console.WriteLine(array.Length - longestIncSeq[longestIncSeq.Length - 1]);
        }
    }
}
