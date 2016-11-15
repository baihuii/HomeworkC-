using System;

namespace MostFrequent
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int number = 0;
            int count = 0;


            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < arr.Length - 1; i += 1)
            {
                int tempNumber = arr[i];
                int tempCount = 0;
                for (int p = 0; p < arr.Length; p++)
                {
                    if (arr[p] == tempNumber)
                    {
                        tempCount++;
                    }
                }
                if(tempCount > count)
                {
                    number = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("{0} ({1} times)", number, count);
        }
    }
}

//4 1 1 4 2 3 4 4 1 2 4 9 3
