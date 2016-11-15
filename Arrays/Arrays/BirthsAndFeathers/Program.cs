using System;
using System.Numerics;
namespace BirthsAndFeathers
{
    class Program
    {
        static void Main()
        {
            long evenMagicNumber = 123123123123;
            int oddMagicNumber = 317;
            int B = int.Parse(Console.ReadLine());
            int F = int.Parse(Console.ReadLine());
            double avgFeatherCount = F / (double)B;
            BigInteger result1;
            if(B != 0 && F != 0)
            {
                if (B % 2 == 0)
                {
                    Console.WriteLine("{0:F4}", avgFeatherCount * evenMagicNumber); 
                }
                else
                {
                    Console.WriteLine("{0:F4}", avgFeatherCount / oddMagicNumber);
                }
            }
            else
            {
                result1 = 0;
                Console.WriteLine(result1);
            }

        }
    }
}
