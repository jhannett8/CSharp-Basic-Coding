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
            int Value1 = op.operation(number1);
            Console.WriteLine(number1 + " + 2 = " + Value1);
            
            Operations opp = new Operations();
            decimal Value2 = opp.operation(number2);
            Console.WriteLine(number2 + " + 2.5 = " + Value2);

            Operations Opp = new Operations();
            int Value3 = Opp.operation(number3);
            Console.WriteLine(number3 + " + 2 = " + Value3);

            Console.ReadLine();

        }
    }
}
