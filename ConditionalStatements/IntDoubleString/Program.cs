using System;

namespace IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordType = Console.ReadLine();
            string wordValue = Console.ReadLine();

            switch (wordType)
            {
                case "integer": Console.WriteLine("{0}", (int.Parse(wordValue)+1));
                    break;
                case "real":
                    Console.WriteLine("{0:F2}", double.Parse(wordValue) + 1);
                    break;
                case "text":
                    Console.WriteLine(wordValue + "*");
                    break;
            }
        }
    }
}
