using System;

namespace MMSA
{
    class Program
    {
        static void Main()
        {


            int n = int.Parse(Console.ReadLine());
            int n_NV = n;
            double sum = 0;
            double biggest = -1000;
            double smallest = 1000;
            

            while (n > 0)
            {
                double numbers = Double.Parse(Console.ReadLine());
                sum += numbers;
                if (biggest < numbers)
                {
                    biggest = numbers;
                }
                if (smallest > numbers)
                {
                    smallest = numbers;
                }
                n -= 1;
                
             }
            
            Console.WriteLine("min={0:f2}", smallest);
            Console.WriteLine("max={0:f2}", biggest);
            Console.WriteLine("sum={0:f2}", sum);
            Console.WriteLine("avg={0:f2}", sum / n_NV);
        }
    }
}

