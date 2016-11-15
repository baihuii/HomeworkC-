using System;

namespace OneToN
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(n, 2));
            for(int i = 1;i <= n; i += 1)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
