using System;

namespace BinToDec
{
    class Program
    {
        static void Main()
        {

            string numBin = Console.ReadLine();
            string numBinReversed = ""; 
            double numLong = 0;
            for (int i = numBin.Length - 1; i >= 0; i--)
            {

                numBinReversed = numBinReversed + numBin[i];
            }

            for(int i = 0; i < numBinReversed.Length; i += 1)
            {

                int temp = numBinReversed[i] - '0';
                double current = temp * (Math.Pow(2, i));
                numLong += current;
                
            }

            Console.WriteLine(numLong);
        }
    }
}
