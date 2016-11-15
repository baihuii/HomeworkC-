using System;

namespace DecimalToHex
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            string reverseHex = "";
            string hex = "";
            long remainder;
            while (N >= 1)
            {
                if (N % 16 == 0)
                {
                    reverseHex += "0";
                }
                else
                {
                    remainder = N % 16;

                    switch (remainder.ToString())
                    {
                        case "10":
                            reverseHex += "A";
                            break;
                        case "11":
                            reverseHex += "B";
                            break;
                        case "12":
                            reverseHex += "C";
                            break;
                        case "13":
                            reverseHex += "D";
                            break;
                        case "14":
                            reverseHex += "E";
                            break;
                        case "15":
                            reverseHex += "F";
                            break;
                        default:
                            reverseHex += remainder;
                            break;
                    }

                }

                N = N / 16;
            }
            for (int i = reverseHex.Length -1; i >= 0; i--)
            {
                hex = hex + reverseHex[i];
            }
            Console.WriteLine(hex);
        }
    }
}
