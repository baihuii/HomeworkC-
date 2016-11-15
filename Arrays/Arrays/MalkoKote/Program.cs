using System;

namespace MalkoKote
{
    class Program
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            char space = char.Parse(" ");
            
            //ears
            Console.Write(new string(space, 1));
            Console.Write(new string(ch, 1));
            Console.Write(new string(space, s/4-1));
            Console.WriteLine(new string(ch, 1));

            //head
            for(int i = 1; i <= s/4-1; i++)
            {
                
                Console.Write(new string(space, 1));
                Console.WriteLine(new string(ch, s / 4 + 1));
            }

            //neck
            for (int i = 1; i <= s / 6; i++)
            {

                Console.Write(new string(space, 2));
                Console.WriteLine(new string(ch, s / 4 - 1));

            }

            //upper body
            for (int i = 1; i <= s / 6; i++)
            {

                Console.Write(new string(space, 1));
                Console.WriteLine(new string(ch, s / 4 + 1));

            }
            //upper body last

            Console.Write(new string(space, 1));
            Console.Write(new string(ch, s / 4 + 1));
            Console.Write(new string(space, 3));
            Console.WriteLine(new string(ch, s / 4 ));

            //lower body
            for (int i = 1; i <= s / 4+1; i++)
            {
                Console.Write(new string(ch, s / 4 + 3));
                Console.Write(new string(space, 2));
                Console.WriteLine(new string(ch, 1));
            }

            //lower body last

            Console.Write(new string(ch, s / 4 + 3));
            Console.Write(new string(space, 1));
            Console.WriteLine(new string(ch, 2));

            //last
            Console.Write(new string(space, 1));
            Console.WriteLine(new string(ch, s / 4 + 4));

        }
    }
}
