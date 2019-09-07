using System;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Operations op = new Operations();
            op.operation(number1, number2);

        }
    }
}
