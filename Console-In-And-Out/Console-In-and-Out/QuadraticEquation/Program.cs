using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it(prints its real roots).
            //Input
            //On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order
            //Output
            //If two different real roots exist, print them on two separate lines
            //Print the smaller root on the first line
            //If only one real root exists, print it on the only output line
            //If no real root exists, print the string "no real roots"
            //The roots, should they exist, must be printed with precision exactly two digits after the floating point
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double x = (-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
            double y = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);

            bool test_x = Double.IsNaN(x);
            bool test_y = Double.IsNaN(y);  
            if (test_x && test_y)
            {
                Console.WriteLine("no real roots");
            }
            else if (x==y)
            {
                Console.WriteLine("{0:F2}", x);
            }
            else
            {
                if (x < y)
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", x, y);
                }
                else
                {
                    Console.WriteLine("{0:F2}\n{1:F2}", y, x);

                }
            }
        }
    }
}
