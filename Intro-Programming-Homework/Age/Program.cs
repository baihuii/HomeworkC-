using System;

namespace AgePlusTen
{
    class Program
    {
        static void Main()
        {

            DateTime BirthDay = DateTime.Parse(Console.ReadLine());
            int age = (int)((DateTime.Now.AddMonths(-7) - BirthDay).TotalDays / 365.242199);
            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
//using System;

//namespace Age
//{
//    class Age
//    {
//        static void Main()
//        {
//            DateTime userBirthDate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
//            DateTime currentDate = DateTime.Now.AddMonths(-7);
//            int age = new int();
//            if (currentDate.Month > userBirthDate.Month)
//            {
//                age = currentDate.Year - userBirthDate.Year;
//                Console.WriteLine(age);
//                Console.WriteLine(age+10);
//            }
//            else if (currentDate.Month == userBirthDate.Month && currentDate.Day >= userBirthDate.Day)
//            {
//                age = currentDate.Year - userBirthDate.Year;
//                Console.WriteLine(age);
//                Console.WriteLine(age + 10);
//            }
//            else if (currentDate.Month == userBirthDate.Month && currentDate.Day < userBirthDate.Day)
//            {
//                age = currentDate.Year - userBirthDate.Year - 1;
//                Console.WriteLine(age);
//                Console.WriteLine(age + 10);
//            }
//            else
//            {
//                age = currentDate.Year - userBirthDate.Year - 1;
//                Console.WriteLine(age);
//                Console.WriteLine(age + 10);
//            }
//        }
//    }
//}
