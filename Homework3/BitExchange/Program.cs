using System;

namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            //            BitExchange
            //Description
            //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32 - bit unsigned integer(read from the console).
            //Input
            //    On the only input line you will receive the unsigned integer number whose bits you must exchange.
            //Output
            //    On the only output line print the value of the integer with the exchanged bits.

            int x = int.Parse(Console.ReadLine());
            int first_three_bits = x & 0x00000038;
            int second_three_bits = x & 0x7000000;
            x &= ~0x07000038; //clears bits 3,4,5,24,25,26
            x |= first_three_bits << 21; // put bits 3-5 in 24-26
            x |= second_three_bits >> 21; // put bits 24-26 in 3-5
            Console.WriteLine(x);
            //change
        }
    }
}
