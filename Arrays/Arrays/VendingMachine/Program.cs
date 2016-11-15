using System;

namespace VendingMachine
{
    class Program
    {
        static void Main()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            double amount = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double change = amount - price;


            double tray1 = 0.05;
            double tray2 = 0.1;
            double tray3 = 0.2;
            double tray4 = 0.5;
            double tray5 = 1.0;

            double tray1_amount = tray1 * n1;
            double tray2_amount = tray2 * n2;
            double tray3_amount = tray3 * n3;
            double tray4_amount = tray4 * n4;
            double tray5_amount = tray5 * n5;


            double totalAmount = tray1_amount + tray2_amount + tray3_amount + tray4_amount + tray5_amount;
            

            if(price > amount )
            {
                Console.WriteLine("More {0:F2}", price - amount);
            }else if(amount > price && totalAmount - change >= 0)
            {
                Console.WriteLine("Yes {0:F2}", totalAmount - change);
            }else if(totalAmount - change<0){
                Console.WriteLine("No {0:F2}", change - totalAmount);
            }else
            {
                Console.WriteLine("Yes {0:F2}", totalAmount);
            }
        }
    }
}
