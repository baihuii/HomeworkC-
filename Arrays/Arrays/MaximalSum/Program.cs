using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];
            int max_so_far = 0;
            int max_ending_here = 0;
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i += 1)
            {
                max_ending_here += arr[i];
                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                }
                if(max_so_far < max_ending_here)
                {
                    max_so_far = max_ending_here;
                }
                //Loop for each element of the array
                //  (a) max_ending_here = max_ending_here + a[i]
                //  (b) if (max_ending_here < 0)
                //                        max_ending_here = 0
                //              (c) if (max_so_far < max_ending_here)
                //                    max_so_far = max_ending_here
                //return max_so_far
            }
            Console.WriteLine(max_so_far);
        }
    }
}
