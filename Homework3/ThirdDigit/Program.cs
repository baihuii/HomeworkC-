using System;

namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            //       Description
            //       Write a program that reads an integer N from the console and prints true if the third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
            //       The counting is done from right to left, meaning 123456's third digit is 4.
            //       Input
            //       The input will always consist of exactly one line, containing the number N.
            //       Output
            //       The output should be a single line -print whether the third digit is 7, following the format described above.
            //       Constraints
            //       N will always be valid non - negative integer number.
            //    Time limit: 0.1s
            //    Memory limit: 16MB
            //                Sample tests
            //Input   Output
            //5   false 0
            //701     true
            //9703    true
            //877     false 8
            //777877  false 8
            //9999799     true
            int N = int.Parse(Console.ReadLine());
            int tempNum = N / 100;
            int checkNum = tempNum % 10;
            if(checkNum == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", checkNum);
            }
            
        }
    }
}
