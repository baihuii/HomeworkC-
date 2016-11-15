using System;

namespace BatGoiko
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int lineRow = 2;
            int lineUpdade = 2;

            for (int row = 1; row <= N ; row++)
            {
                string sideDots = new string('.', N - row);
                char insideSymbol = '.';
                if(lineRow == row)
                {
                    insideSymbol = '-';
                    lineRow += lineUpdade;
                    lineUpdade++;

                    
                }
                string inside = new string(insideSymbol, row - 1);
                Console.Write(sideDots);
                Console.Write('/');
                Console.Write(inside);
                Console.Write(inside);
                Console.Write('\\');
                Console.WriteLine(sideDots);

            }
        }
    }
}
///--------------------\


//../....\..
//./------\.
///........\
