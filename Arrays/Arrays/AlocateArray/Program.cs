using System;

namespace AlocateArray
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }

        }
    }
}
