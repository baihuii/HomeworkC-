using System;
using System.Numerics;

namespace squirrels
{
    class Program
    {
        static void Main(string[] args)
        {
            double trees = int.Parse(Console.ReadLine());
            double branches = int.Parse(Console.ReadLine());
            double squirrelsOnbranch = int.Parse(Console.ReadLine());
            double avg_tails = int.Parse(Console.ReadLine());
            int ifEven = 376439;
            int ifOdd = 7;
            double totalTails = trees*branches*squirrelsOnbranch*avg_tails;
            if(totalTails % 2 == 0)
            {
                double test = totalTails * ifEven;
                Console.WriteLine("{0:F3}", test);
            }
            else
            {
                double result = (double)totalTails / ifOdd;
                Console.WriteLine("{0:F3}",result);
            }



        }
    }
}
