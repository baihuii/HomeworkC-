﻿using System;

namespace BonusScore
{
    class Program
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            if (score <= 0 || score > 9)
            {
                Console.WriteLine("invalid score");
            }
            else if(score>=1 && score <=3)
            {
                score *= 10;
                Console.WriteLine(score);
            }
            else if (score >= 4 && score <= 6)
            {
                score *= 100;
                Console.WriteLine(score);
            }
            else if (score >= 7 && score <= 9)
            {
                score *= 1000;
                Console.WriteLine(score);
            }
        }
    }
}
