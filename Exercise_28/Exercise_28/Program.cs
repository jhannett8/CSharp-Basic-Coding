using System;

namespace Exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a const variable
            const int Months = 12;
            Console.WriteLine("const holds the in = {0}", Months);
            //create a variable with the keyword var
            var age = 25;
            Console.WriteLine("var holds an int = {0}", age);
        }
    }
}