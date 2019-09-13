using System;

namespace Exercise_27
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today's date is: {0}", today);
            Console.WriteLine("Please input the amount of hours you would like to add to today's current time; ");
            double hours = Convert.ToDouble(Console.ReadLine());
            DateTime NewTime= today.AddHours(hours);
            Console.WriteLine("The new time is; {0}", NewTime);
        }
    }
}
