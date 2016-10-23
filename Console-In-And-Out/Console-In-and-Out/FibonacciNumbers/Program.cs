using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main()
        {

            //    int a = 0, b = 1, c = 0;

            //    Console.Write("{0} {1}", a, b);



            //    for (int i = 2; i < len; i++)

            //    {

            //        c = a + b;

            //        Console.Write(" {0}", c);

            //        a = b;

            //        b = c;

            //    }

            //}


            sbyte n = sbyte.Parse(Console.ReadLine());
            if (n >= 0 && n <= 50)
            {
                long num1 = 0;
                long num2 = 1;

                if (n == 1)
                {
                    Console.WriteLine(num1);
                }
                else if (n == 2)
                {
                    Console.WriteLine("{0}, {1}", num1, num2);
                }
                else
                {
                    Console.Write("{0}, {1}, ", num1, num2);
                    string test = "";
                    for (int i = 0; i < n - 2; i++)
                    {
                        long sum = num1 + num2;
                        num1 = num2;
                        num2 = sum;



                        test += num2 + ", ";
                        //test = test.TrimEnd(',');

                        //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233
                    }
                    string test_trimmed = test.TrimEnd(',', ' ');


                    Console.Write(test_trimmed);
                }
            }
        }
    }
}
