using System;

namespace NumberPages
{
    class Program
    {
        static void Main()
        {
            
            int D = int.Parse(Console.ReadLine());

            int pages = 0;

            for(int i = 1; D !=0; i++)
            {
                pages++;
                if (i < 10)
                {
                    D -=1 ;

                }
                else if(i < 100)
                {
                    D -= 2;
                }
                else if(i < 1000)
                {
                    D -= 3;
                }
                else if (i < 10000)
                {
                    D -= 4;
                }
                else if (i < 100000)
                {
                    D -= 5;
                }
                else if (i < 1000000)
                {
                    D -= 6;
                }
            }
            Console.WriteLine(pages);
            }
        }
    }

