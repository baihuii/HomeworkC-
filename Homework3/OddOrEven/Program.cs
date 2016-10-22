﻿using System;

namespace OddOrEven
{
    class Program
    {
        static void Main()
        {

            //            Write a program that reads an integer from the console, uses an expression to check if given integer is odd or even, and prints "even NUMBER" or 
            //            "odd NUMBER", where you should print the input number's value instead of NUMBER.
            //Input

            //    On the single input line you will receive an integer number.

            //Output

            //    Output a single line - if the number is even, output even, followed by a whitespace and the value of the number.Otherwise, print odd, again followed 
            //                by a whitespace and the number's value. See the sample tests.

            //Constraints

            //    The input number will always be a valid integer number.
            //    The input number will always be in the range[-30, 30].

            int inputNumber = int.Parse(Console.ReadLine());
            if(inputNumber % 2 == 0)
            {
                Console.WriteLine("even {0}", inputNumber);
            }
            else
            {
                Console.WriteLine("odd {0}", inputNumber);
            }
        }
    }
}
