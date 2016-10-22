using System;

namespace ThirdBit
{
    class Program
    {
        static void Main()
        {
            //            Description
            //Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.
            //    The bits are counted from right to left, starting from bit 0.
            //    The result of the expression should be either 1 or 0.Print it on the console.
            //Input
            //    On the only input line, you will receive a single positive integer -the number whose 3rd bit you must print.
            //Output
            //   Output a single number - 1 or 0 - the value of the 3rd bit, counted from 0 and from right to left.
            //Constraints
            //   The input number will always be a valid positive integer number.
            //    Time limit: 0.1s
            //    Memory limit: 16MB
            //Sample tests
            //Input   Output
            //15  1
            //1024    0
            uint x = uint.Parse(Console.ReadLine());
            uint shifted_x = x >> 3;
            //Console.WriteLine(shifted_x);
            Console.WriteLine(shifted_x % 2);
            //uint remainder;
            //string result = string.Empty;
            //while (x > 0)
            //{
            //    remainder = x % 2;
            //    x /= 2;
            //    result = remainder.ToString() + result;
            //}
            //Console.WriteLine("Binary:  {0}", result);
        }
    }
}
