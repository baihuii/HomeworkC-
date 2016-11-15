using System;

namespace TsakiTask
{
    class Program
    {
        static void Main()
        {

            string firstSymbol;
            string secondSymbol;
            string thirdSymbol;
            string output = "";
            bool res = true;
            while (res)
            {
                firstSymbol =Console.ReadLine();
                secondSymbol = Console.ReadLine(); 
                thirdSymbol = Console.ReadLine();

                if(firstSymbol == "end")
                {
                    res = false;
                }
                else
                {
                    int first = int.Parse(firstSymbol);
                    int second = int.Parse(secondSymbol);
                    
                    for(int i = first; i < thirdSymbol.Length; i += second)
                    {
                        output += thirdSymbol[i];
                    }

                }
            }
            Console.WriteLine(output);

        }
    }
}
