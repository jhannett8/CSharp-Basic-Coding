using System;

namespace Exercise_23
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World! What day is today?");
                string day = Console.ReadLine();
                DayOfWeek today = DateTime.Today.DayOfWeek;

                if (day == (Convert.ToString(today)))
                {
                    Console.WriteLine("Your right! Today is {0}!", day);
                }
                else
                {
                    Console.WriteLine("Please select the correct day of the week.");
                }

            }
            catch
            {
                Console.WriteLine("Please select the correct day of the week.");
            }
        }
    }
}
