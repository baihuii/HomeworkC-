using System;

namespace PrintMyName
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("your name is {0} {1}", name);

            //byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
            byte test_byte = 97;
            sbyte test_sbyte = -115;
            short test_short = -10000;
            ushort test_ushort = 52130;
            int test_int = 4825932;

            //34.567839023, 12.345, 8923.1234857, 3456.091


            float test_double1 = 233;
            float test_float1 = 3456.091f;
            double test_double2 = 34.567839023;
            int test_hex = 0xFE;
            double test = 8923.1234857;
            bool isFemale = false;
            Console.WriteLine(isFemale);
            char tst_char = '\u002A';
            Console.WriteLine(tst_char);




        }   
    }
}
