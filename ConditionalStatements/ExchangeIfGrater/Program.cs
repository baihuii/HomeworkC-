using System;

namespace ExchangeIfGrater
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double bigger = B;
            if (A < B)
            {
                Console.WriteLine("{0} {1}", A, bigger );

            }
            else
            {
                bigger = A;
                Console.WriteLine("{0} {1}", B, bigger);
            }

            
        }
    }
}

