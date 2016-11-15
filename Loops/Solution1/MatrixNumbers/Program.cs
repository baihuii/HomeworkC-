using System;

namespace MatrixNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {

                for (int column = row; column < n + row; column++)
                {
                    Console.Write("{0} ", column);

                }
                Console.WriteLine();
            }

        }
    }
}

//using System;

//namespace MatrixNumbers
//{
//    class Program
//    {
//        static void Main()
//        {
//            int n = int.Parse(Console.ReadLine());
//            for (int column1 = 1 ; column1 <= n; column1++)
//            {

//                Console.Write("{0} {1} {2}", column1);
//                Console.WriteLine();

//            }

//        }
//    }
//}
