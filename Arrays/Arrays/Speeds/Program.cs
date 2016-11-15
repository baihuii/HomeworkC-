using System;

namespace Speeds
{
    class Program
    {
        static void Main()
        {
            int cars = int.Parse(Console.ReadLine());
            int currentSpeed = 0;
            int sumSpeeds = 0;
            int groups = 0;
            int groupSpeed = 0;
            int bestSpeed = 0;
            int biggestCount = 0;

            for (int i = 1; i <= cars; i++)
            {
                int carSpeed = int.Parse(Console.ReadLine());
                if(i==1)
                {
                    currentSpeed = carSpeed;
                    sumSpeeds = carSpeed;
                    groups = 1;

                }
                else
                {
                    if (carSpeed > currentSpeed)
                    {
                        sumSpeeds += carSpeed;
                        groups += 1;
                    }
                    if(carSpeed == currentSpeed)
                    {
                        groups = 1;
                        sumSpeeds = carSpeed;
                    }
                    if(carSpeed < currentSpeed)
                    {
                        groups = 1;
                        currentSpeed = carSpeed;
                        sumSpeeds = carSpeed;
                    }
                }
                if (groups > biggestCount)
                {
                    biggestCount = groups;
                    bestSpeed = sumSpeeds;

                }
                if ((groups == biggestCount) && (sumSpeeds > bestSpeed))
                {
                    bestSpeed = sumSpeeds;
                }
            }
            Console.WriteLine(bestSpeed);
        }
    }
}
