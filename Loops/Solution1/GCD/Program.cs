using System;

namespace GCD
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int A = Convert.ToInt32(numbers[0]);
            int B = Convert.ToInt32(numbers[1]);
            int reminder;
            while (A > 0 && B > 0)
            {
                if (A > B)
                {
                    reminder = A % B;
                    A = B;
                    B = reminder;
                }
                else
                {
                    reminder = B % A;
                    B = A;
                    A = reminder;
                }

            }
            if(A == 0)
            {
                Console.WriteLine(B);
            }
            else
            {
                Console.WriteLine(A);
            }
        }
    }
}
