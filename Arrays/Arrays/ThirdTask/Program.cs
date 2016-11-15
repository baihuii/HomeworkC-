using System;

namespace ThirdTask
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] mutliply = new int[n - 1];
            int[] substract = new int[n - 1];

            for (int i = 1; i < arr.Length; i++)
            {

                mutliply[i-1] = (arr[i - 1] % 10) * (arr[i] / 10);
               
            }

            for (int i = 1; i < arr.Length; i++)
            {

                substract[i - 1] = Math.Abs(arr[i - 1] - arr[i]);

            }


            //for (int i = 0; i < mutliply.Length; i++)
            //{
            //    Console.Write(String.Join(" ", mutliply[i]));

            //}
            //Console.WriteLine();
            //for (int i = 0; i < substract.Length; i++)
            //{
            //    Console.Write(String.Join(" ", substract[i]));
            //}
            Console.WriteLine(String.Join(" ", mutliply));
            Console.WriteLine(String.Join(" ", substract));
        }
    }
}
