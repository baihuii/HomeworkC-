using System;

namespace Exchange
{
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            int c = a;
            //int d = b;
            a = b;
            b = c;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);


        }
    }
}
