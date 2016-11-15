using System;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main()
        {
            int rounds = int.Parse(Console.ReadLine());
            int drunkenNumber;
            int mitkoBeers=0;
            int vladkoBeers=0;
                     
            for (int i = 0; i < rounds; i++)
            {
                drunkenNumber = int.Parse(Console.ReadLine());

                if (drunkenNumber < 0)
                {
                    drunkenNumber *= -1;
                }

                int numberOfDigits = 0;
                int num = drunkenNumber;
                while (num != 0)
                {
                    num /= 10;
                    numberOfDigits++;
                }


                for(int p = 0; p < numberOfDigits / 2; p++)
                {
                    int currentDigit = drunkenNumber % 10;
                    vladkoBeers += currentDigit;
                    drunkenNumber /= 10;
                }

                if(numberOfDigits % 2 == 1)
                {
                    int middleDigit = drunkenNumber % 10;
                    vladkoBeers += middleDigit;
                    mitkoBeers += middleDigit;
                    drunkenNumber /= 10;
                }

                for (int p = 0; p < numberOfDigits / 2; p++)
                {
                    int currentDigit = drunkenNumber % 10;
                    mitkoBeers += currentDigit;
                    drunkenNumber /= 10;
                }

            }
            if(mitkoBeers > vladkoBeers)
            {
                Console.WriteLine("M {0}", mitkoBeers- vladkoBeers);
            }else if(vladkoBeers > mitkoBeers)
            {
                Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
            }else
            {
                Console.WriteLine("No {0}", vladkoBeers*2);
            }
            
        }
    }
}
//On the only output line your program should print the first letter of the winner’s name
//(“M” for Mitko and “V” for Vladko) and a space followed by a number representing how much 
//more beers the winner has drank.If there is no winner print “No” followed by a space and the total drunken beers.