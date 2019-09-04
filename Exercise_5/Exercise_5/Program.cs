using System;

namespace Exercise_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);
            Console.WriteLine("true or false: Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int Tickets = Convert.ToInt32(tickets);
            Console.WriteLine("Qualified ?");
            bool Qualified = (Age > 15  && DUI == "false" && Tickets < 3);
            Console.WriteLine(Qualified);
        }
    }
}
