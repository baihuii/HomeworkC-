using System;

namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];
            bool isEqal = true;
            for (int i = 0; i < n; i++)
            {
                
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                if(arr1[i] != arr2[i])
                {
                    isEqal = false;
                    break;
                }
            }
            if (isEqal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            
        }
    }
}
