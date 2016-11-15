using System;
using System.Numerics;

namespace Calculate
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            BigInteger n2 = 2*n;
            BigInteger nPlusOne = n + 1;
            BigInteger n2Fact = 1;
            BigInteger nPlus1Fact = 1;
            BigInteger Catalan;
            for(int i = 1; i <= n; i += 1)
            {
                nFact *= i;
               
            }
            for (int i = 1; i <= n2; i += 1)
            {
                n2Fact *= i;
            }
            for (int i = 1; i <= nPlusOne
                ; i += 1)
            {
                nPlus1Fact *= i;
            }

            Catalan = n2Fact / (nPlus1Fact * nFact);
            Console.WriteLine(Catalan);
        }
    }
}


