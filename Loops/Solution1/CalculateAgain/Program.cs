using System;
using System.Numerics;

namespace Calculate
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = 1; i <= n; i += 1)
                {
                    if (i <= k)
                    {
                        kFactorial *= i;
                    }
                    nFactorial *= i;
                }
            }
            
            Console.WriteLine(nFactorial / kFactorial);
        }
    }
}


