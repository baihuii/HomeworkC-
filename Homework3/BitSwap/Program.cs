using System;

namespace BitSwap
{
    class Program
    {
        static void Main()
        {
            //            BitSwap
            //Description
            //Write a program first reads 4 numbers n, p, q and k and than swaps bits { p, p + 1, …, p + k - 1}
            //            with bits { q, q + 1, …, q + k - 1}
            //            of n. Print the resulting integer on the console.
            //Input
            //On the only four lines of the input you will receive the integers n, p, q and k in this order.
            //Output
            //Output a single value - the value of n after the bit swaps.
            //Constraints
            //The first and the second sequence of bits will never overlap.
            //    n will always be a valid 32 - bit positive integer.
            //    p, q >= 0
            //    p + k - 1, q + k - 1 < 32
            //    Time limit: 0.1s
            //    Memory limit: 16MB
            uint n = uint.Parse(Console.ReadLine());
            uint p = uint.Parse(Console.ReadLine());
            uint q = uint.Parse(Console.ReadLine());
            uint k = uint.Parse(Console.ReadLine());

            for (int i = (int)q; i <= q + k - 1; i++)
            {
                uint checkP = (n >> (int)p) & 1;
                uint checkQ = (n >> i) & 1;

                if (checkP != checkQ)
                {
                    n = n ^ ((uint)1 << (int)p);
                    n = n ^ ((uint)1 << i);
                }
                p++;
            }

            Console.WriteLine(n);
        }
    }
}
