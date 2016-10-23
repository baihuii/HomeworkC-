using System;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double final_num = 0;
            for(int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                final_num += num;
            }
            Console.WriteLine(final_num);
        }
    }
}
