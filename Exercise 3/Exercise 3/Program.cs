using System;

namespace Exercise_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please, inser a number.");
            string number_1 = Console.ReadLine();
            int Number_1 = Convert.ToInt32(number_1);
            int total_1 = Number_1 * 50;
            Console.WriteLine("Your Number, Multiplied by 50 is: " + total_1);

            Console.WriteLine("Please, insert another number.");
            string number_2 = Console.ReadLine();
            int Number_2 = Convert.ToInt32(number_2);
            int total_2 = Number_2 + 25;
            Console.WriteLine("Your Number, added to 25 is: " + total_2);

            Console.WriteLine("Please, insert another number.");
            string number_3 = Console.ReadLine();
            int Number_3 = Convert.ToInt32(number_3);
            double total_3 = Number_3 / 12.5;
            Console.WriteLine("Your Number, divided by 12.5 is: " + total_3);
            
            Console.WriteLine("Please, insert another number.");
            string number_4 = Console.ReadLine();
            int Number_4 = Convert.ToInt32(number_4);
            Console.WriteLine("Is your number, " + Number_4 + " greater than 50? " + (Number_4 > 50));
            Console.WriteLine("Please, insert another number.");
            string number_5 = Console.ReadLine();
            int Number_5 = Convert.ToInt32(number_5);
            int total_5 = Number_5 / 7;
            int remainder_5 = Number_5 % 7;
            Console.WriteLine("Your Number, divided by 7 is: " + total_5);
            Console.WriteLine("With a remainder of: " + remainder_5);
            Console.WriteLine();
        }
    }
}
