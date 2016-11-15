using System;

namespace OddEven
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] nums = Console.ReadLine().Split(' ');
            int[] numbers = Array.ConvertAll(nums, int.Parse);
            long sumOdd = 1;
            long sumEven = 1;
            for(int i = 0; i < numbers.Length; i += 1)
            {   

                if(i % 2 == 0)
                {
                    sumEven *= numbers[i];
                }
                else
                {
                    sumOdd *= numbers[i];
                }
               
            }
            if(sumEven == sumOdd)
            {
                Console.WriteLine("yes {0}", sumEven);
            }
            else
            {
                Console.WriteLine("no {0} {1}", sumEven, sumOdd);
            }
            

        }
    }
}
