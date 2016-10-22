using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main()
        {
            //A bank account has a holder name(first name, middle name and last name), 
            //available amount of money (balance), bank name, IBAN, 3 credit card numbers 
            //    associated with the account.Declare the variables needed to keep the information
            //    for a single bank account using the appropriate data types and descriptive names.
            string firstName = "";
            string middleName = "";
            string lastName = "";
            string holderName = firstName + middleName + lastName;
            decimal balance = 345M;
            string bankName = "";
            string IBAN = "BG12TTBB94001527312603";
            Console.WriteLine(IBAN.GetType());

            double testDouble = 0;
            int testInt = 0;
            Console.WriteLine((testDouble + 7));

        }
    }
}
