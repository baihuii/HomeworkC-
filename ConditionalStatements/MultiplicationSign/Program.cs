using System;

namespace MultiplicationSign
{
    class Program
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if (first != 0 && second != 0 && third != 0)
            {
                if (first < 0 && second > 0 && third > 0)
                {
                    Console.WriteLine("-");
                }
                else if (first > 0 && second < 0 && third > 0)
                {
                    Console.WriteLine("-");
                }
                else if (first > 0 && second > 0 && third < 0)
                {
                    Console.WriteLine("-");
                }
                else if (first < 0 && second < 0 && third < 0)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("+");
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
