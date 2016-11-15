using System;

/// <summary>
/// Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
/// Your program should work well for very big numbers, e.g.N = 100000.
/// </summary>
class Trailing0inNFact
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {


        int num = int.Parse(Console.ReadLine());

        int zeros = 0;
        while (num >= 5)
        {
            num /= 5;
            zeros += num;
        }
        Console.WriteLine(zeros);
    }
}
