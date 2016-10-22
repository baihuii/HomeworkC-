﻿using System;

namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            //            Description
            //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
            //    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
            //    Prints on the console the number in reversed order: dcba(in our example 1102) and prints the reversed number.
            //   Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
            //    Exchanges the second and the third digits: acbd(in our example 2101) and prints the result.
            //Input
            //    The input will consist of a single four - digit integer number on a single line.
            //Output
            //    Output the result of each action on a separate line, in the same order as they are explained above:
            //    meaning the sum comes on the first line, the reversed number on the second, and so on.
            //Constraints
            //        The number will always be a valid positive four-digit integer.
            //        The number will always start with a digit other than 0.
            //        Time limit: 0.1s
            //        Memory limit: 16MB
            //    Sample tests
            //    Input   Output
            //2011    4
            //        1102
            //      1201
            //      2101
            //3333    12
            //      3333
            //      3333
            //      3333
            //9876    30
            //      6789
            //      6987
            //      9786
            //1230    6
            //      0321
            //      0123
            //      1320

            int input = int.Parse(Console.ReadLine());
            int d = input % 10;
            input /= 10;
            int c = input % 10;
            input /= 10;
            int b = input % 10;
            int a = input / 10;
            string reverse = String.Format("{0}{1}{2}{3}", d, c, b, a);
            int reverse1 = int.Parse(reverse);
            Console.WriteLine(d + c + b + a);
            Console.WriteLine(reverse1);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
