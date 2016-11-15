using System;

namespace Busses
{
    class Program
    {
        static void Main()
        {

            int numBusses = int.Parse(Console.ReadLine());
            int groups = 0;
            int groupSpeed = int.MaxValue;

            for (int i = 0; i < numBusses; i++)
            {
                int busSPeed = int.Parse(Console.ReadLine());
                if (busSPeed <= groupSpeed)
                {
                    groups++;
                    groupSpeed = busSPeed;
                }
            }

            Console.WriteLine(groups);
        }
    }
}





