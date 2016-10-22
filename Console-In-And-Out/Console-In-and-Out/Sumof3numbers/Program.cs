using System;

namespace SumOf3Numbers
{
    class Program
    {
        static void Main()
        {
            //            Sum of 3 numbers
            //Description
            //Write a program that reads 3 real numbers from the console and prints their sum.
            //Input
            //    On the first line, you will receive the number a
            //    On the second line, you will receive the number b
            //    On the third line, you will receive the number c
            //Output
            //Your output should consist only of a single line -the sum of the three numbers.
            //Constraints
            //   a, b and c will always be valid real numbers between - 1000 and 1000, inclusive
            //    Time limit: 0.1s
            //    Memory limit: 16MB

            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());

            if((a <= 1000 && a >= -1000) && (b <= 1000 && b >= -1000) && (c <= 1000 && c >= -1000))
            {
                Console.WriteLine(a + b + c);
            }
        }
    }
}
