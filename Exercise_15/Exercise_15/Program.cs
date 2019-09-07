using System;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a decimal number: ");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            string number3 = Console.ReadLine();

            Operations op = new Operations();
            op.operation(number1);
            

            Operations opp = new Operations();
            opp.operation(number2);

            Operations Opp = new Operations();
            Opp.operation(number3);

            Console.ReadLine();

        }
    }
}
