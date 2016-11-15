using System;

namespace EvenDivisors
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = A; i <= B; i += 1)
            {
                for (int j = 1; j <= i; j += 1) {
                    if (i % j == 0 && j % 2 == 0)
                        sum += j;
                }



            }
            Console.WriteLine(sum);

        }
    }
}
