using System;

namespace BiggestOfThree
{
    class Program
    {
        static void Main()
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            if(first > second && first > third)
            {
                Console.WriteLine(first);
            }
            else if(second > first && second > third)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }
        }
    }
}
