using System;

namespace OneToN
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= n; i += 1)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {
                    Console.Write("{0} ", i);
                }
                
            }
        }
    }
}
