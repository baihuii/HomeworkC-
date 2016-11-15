using System;

namespace DecToBin
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string reverseBin = "";
            string bin = "";
            while (N >= 1)
            {
                int nReminder = N / 2;
                reverseBin += (N % 2);
                N = nReminder;
            }


            // Reversing the  value
            for (int i = reverseBin.Length - 1; i >= 0; i--)
            {
                bin = bin + reverseBin[i];
            }
                Console.WriteLine(bin);
        }
    }
}
