using System;

class GoikoTower
{
    static void Main()
    {
        int height = Convert.ToInt16(Console.ReadLine());

        int heightVar = height;

        int z = 0;
        int z2 = 1;

        for (int i = 1; i <= height; i++)
        {
            for (int y = 0; y <= i - z; y++)
            {
                string goikoDot = new String('.', height - z2);
                string goikoDotOpp = new String('.', height - z2);
                string goikoDash = new string('-', ((height - heightVar) * 2));
                string goikoDotCenter = new string('.', ((height - heightVar) * 2));

                Console.Write(goikoDot + '/');

                if ((z == 1) || (z == 3) || (z == 6) || (z == 10) || (z == 15) || (z == 21) || (z == 28) || (z == 36))
                {
                    Console.Write(goikoDash);
                }

                else
                {
                    Console.Write(goikoDotCenter);
                }

                Console.Write('\\' + goikoDotOpp);
                z++;
                z2++;
                heightVar--;
            }
            Console.WriteLine();
        }
    }
}