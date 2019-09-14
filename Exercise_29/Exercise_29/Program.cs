using System;

namespace Exercise_29
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            while (!validAnswer)
            {
                try
                {
                    int Age = 0;
                    Console.WriteLine("\nPlease enter your age: ");
                    validAnswer = int.TryParse(Console.ReadLine(), out Age);
                    if (Age == 0)
                    {
                        Console.WriteLine("Sorry, but I'm pretty sure you're not 0 yrs old...Please enter your correct age!");
                        validAnswer = false;
                    }
                    else if (Age < 0) 
                    {
                        Console.WriteLine("You're messing with me...hopefully. Please enter your correct age!");
                        validAnswer = false;
                    }
                    else
                    {
                        DateTime Today = DateTime.Now;
                        int yr = Today.Year;
                        int Birthyear = yr - Age;
                        Console.WriteLine("Wow! So you were born in {0}!", Birthyear);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry, I didnt quite understand that...Please try again.");
                }
            }
        }
    }
}
