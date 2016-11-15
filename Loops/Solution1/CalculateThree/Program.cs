using System;
using System.Numerics;

namespace CalculateThree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger NMinusKFact = 1;
            BigInteger result;
            for (int i = 1; i <= n; i += 1)
            {
                nFactorial *= i;
                if (i <= k)
                {
                    kFactorial *= i;
                }

            }
            int nMinusK = n - k;
            for (int i = 1; i <= nMinusK; i += 1)
            {
                NMinusKFact *= i;
            }

            result = nFactorial / (kFactorial * NMinusKFact);
            Console.WriteLine(result);
        }
    }
}






//N! / (K! * (N - K)!) for given N and K. 