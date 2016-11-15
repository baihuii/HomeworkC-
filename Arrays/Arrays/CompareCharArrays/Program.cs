using System;

namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int loopLength = str1.Length < str2.Length ? str1.Length : str2.Length;
            string isEqual = "=";
            for (int i = 0; i < loopLength; i++)
            {
                if(str1[i] < str2[i])
                {
                    isEqual = "<";
                    break;
                }
                else if((str1[i] > str2[i]))
                {
                    isEqual = ">";
                    break;
                }
            }
            if(isEqual == "=")
            {
                if(str1.Length < str2.Length)
                {
                    isEqual = "<";
                }
                else if(str1.Length > str2.Length )
                {
                    isEqual = ">";
                }
            }
            Console.WriteLine(isEqual);
        }
    }
}
