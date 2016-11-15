using System;

namespace Calculate
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            long factorial = 1;
            for (int i = 1; i <= N; i += 1)
            {
                factorial *= i;
                double pow = Math.Pow(x, i);
                sum = sum + (factorial / pow);
            }
            //Console.WriteLine(factorial);
            Console.WriteLine("{0:F5}", sum);
        }
    }
}



//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//    Use only one loop.Print the result with 5 digits after the decimal point.
