using System;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            //            Point, Circle, Rectangle
            //Description
            //Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) if it is within the circle K({ 1, 1}, 1.5)
            //and out of the rectangle R(top = 1, left = -1, width = 6, height = 2).
            //Input
            //    You will receive the pair of coordinates on the two lines of the input - on the first line you will find x, and on the second -y.
            //    Output
            //        Print inside circle if the point is inside the circle and outside circle if it's outside. Then print a single whitespace followed by inside rectangle 
            //if the point is inside the rectangle and outside rectangle otherwise. See the sample tests for a visual description.
            //                    Constraints
            //                    The coordinates x and y will always be valid floating - point numbers in the range[-1000, 1000].
            //    Time limit: 0.1s
            //    Memory limit: 16MB
            //                Sample tests
            //Input   Output
            //2.5
            //2   outside circle outside rectangle
            //0
            //1   inside circle inside rectangle
            //2.5
            //1   inside circle inside rectangle
            //1
            //2   inside circle outside rectangle

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool isInCircle = ((x-1) * (x-1)) + ((y-1) * (y-1)) <= (1.5 * 1.5);
            bool insideRectangle = (x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 6));

            if (isInCircle == true && insideRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (isInCircle == false && insideRectangle == false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
            else if (isInCircle == true && insideRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle inside rectangle");
            }

        }
    }
}
