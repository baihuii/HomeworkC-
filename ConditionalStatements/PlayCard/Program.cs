using System;

namespace PlayCard
{
    class Program
    {
        static void Main()
        {
            string card = Console.ReadLine();
            string result = "no";
            string[] valid_cards = { "2" , "3" , "4" , "5" , "6" , "7" , "8" , "9" , "10" , "J" , "Q" , "K" , "A" };
            for(int i = 0; i < valid_cards.Length; i++)
            {
                if (valid_cards[i] == card)
                {
                    result = "yes";
                    break;
                    
                }
                
            }
            Console.WriteLine("{0} {1}",result, card);
        }
    }
}
