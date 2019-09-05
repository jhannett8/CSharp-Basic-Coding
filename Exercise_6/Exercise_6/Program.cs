using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro//
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            
            //dimensions//
            decimal weight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package width:");
            decimal width = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());
           
            //calculations//
            decimal total = weight + width + height + length;
            decimal sum = (total * weight) / 100;
            string result = total < 50 ? "Your estimated total for shipping this package is: $" + sum : "Package too heavy to be shipped via Package Express. Have a good day.";
            Console.WriteLine(result);
            Console.WriteLine("Thank You!");
        }
    }
}
