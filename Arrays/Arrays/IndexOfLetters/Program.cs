using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input.ToUpper();

            char[] array = input.ToCharArray();

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine((int)array[i] - 65);
            }
        }
    }
}
