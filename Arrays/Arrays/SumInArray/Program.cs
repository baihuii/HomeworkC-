using System;
using System.Collections.Generic;

namespace SumInArray
{
    class Program
    {
        static void Main()
        {
            int[] A = { 4, 3, 1, 4, 2, 5, 8 };
            int B = 11;
            int sum = 0;

            for (int i = 0; i < A.Length; i += 1)
            {
                if (sum < B)
                {
                    sum += A[i];
                    List<int> intList = new List<int>();
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
