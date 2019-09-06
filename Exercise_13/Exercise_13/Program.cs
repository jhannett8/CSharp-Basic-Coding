using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number (" + number + ") added by 2:");
            Operator.Add_op(number);

            Console.WriteLine("Your number (" + number + ") subtracted by 2:");
            Operator.Subtract_op(number);

            Console.WriteLine("Your number (" + number + ") divided by 2:");
            Operator.Divide_op(number);

            Console.ReadLine();
        }
    }
}
