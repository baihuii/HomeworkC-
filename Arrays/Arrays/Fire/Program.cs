﻿using System;

namespace Fire
{
    class Program
    {
        static void Main()
        {
            //...##...
            //..#..#..
            //.#....#.
            //#......#
            //#......#
            //.#....#.
            //--------
            //\\\\////
            //.\\\///.
            //..\\//..
            //...\/...
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i<=N/2; i++)
            {
                Console.Write(new string('.', N / 2 - i));
                Console.Write('#');
                Console.Write(new string('.', (i - 1) * 2));
                Console.Write('#');
                Console.WriteLine(new string('.', N / 2 - i));
            }

            for (int i = 1; i <= N/4; i++)
            {
                Console.Write(new string('.', i-1));
                Console.Write('#');
                Console.Write(new string('.', N-i*2));
                Console.Write('#');
                Console.WriteLine(new string('.', i - 1));
            }

            Console.WriteLine(new string('-', N));

            for (int i = 1; i <= N / 2; i++)
            {
                Console.Write(new string('.', i - 1));
                Console.Write(new string('\\', N/2+1-i));
                Console.Write(new string('/', N / 2 + 1 - i));
                Console.WriteLine(new string('.', i - 1));
            }
        }
    }
}
