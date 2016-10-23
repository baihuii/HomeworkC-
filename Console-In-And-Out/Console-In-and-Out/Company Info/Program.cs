using System;

namespace CompanyInfo
{
    class Program
    {
        static void Main()
        {

            //        A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
            //Write a program that reads the information about a company and its manager and prints it back on the console.
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companyWebSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPhone);
            Console.WriteLine(companyFax.Length > 0 ? "Fax: " + companyFax : "Fax: (no fax)");
            Console.WriteLine("Web site: {0}", companyWebSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);

        }
    }
}
