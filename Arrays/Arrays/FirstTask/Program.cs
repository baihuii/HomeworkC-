using System;

namespace FirstTask
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            double third = N % 10;
            N = N / 10;
            double second = N % 10;
            N = N / 10;
            double first = N % 10;

            if(third == 0)
            {
                double output = second * first;
                Console.WriteLine("{0:F2}", output);
            }
            else if(third>0 && third<=5)
            {
                double output = (second * first) / third;
                Console.WriteLine("{0:F2}", output);
            }
            else if (third>5)
            {
                double output = (second + first) * third;
                Console.WriteLine("{0:F2}", output);

            }

            
        }
    }
}



//If the 3rd digit is zero, find the product of the first two digits.
//If the 3rd digit is between 0 and 5 inclusive, find the product of the first two digits and divide the result by the 3rd digit.

//If the 3rd digit is larger than 5, find the sum of the first two digits and multiply the result by the 3rd digit.
