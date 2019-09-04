using System;

namespace Exercise_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1's Information:");
            Console.WriteLine("Whats your Hourly Rate?");
            string rate_1 = Console.ReadLine();
            int hourly_rate_1 = Convert.ToInt32(rate_1);
            Console.WriteLine("How many hours do you work per week?");
            string hours_1 = Console.ReadLine();
            int hours_worked_1 = Convert.ToInt32(hours_1);
            Console.WriteLine("Weekly Salary of Person 1:");
            float wk_salary_1 = hourly_rate_1 * hours_worked_1;
            Console.WriteLine(wk_salary_1);
            Console.WriteLine("Person 2's Information:");
            Console.WriteLine("Whats your Hourly Rate?");
            string rate_2 = Console.ReadLine();
            int hourly_rate_2 = Convert.ToInt32(rate_2);
            Console.WriteLine("How many hours do you work per week?");
            string hours_2 = Console.ReadLine();
            int hours_worked_2 = Convert.ToInt32(hours_2);
            Console.WriteLine("Weekly Salary of Person 2:");
            float wk_salary_2 = hourly_rate_2 * hours_worked_2;
            Console.WriteLine(wk_salary_2);
            Console.WriteLine("Does Person 1 make more money than person 2?");
            if (wk_salary_1 > wk_salary_2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
