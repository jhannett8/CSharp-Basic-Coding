using System;

namespace Exercise_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Void method that outputs an integer 
            Console.WriteLine("Please Log a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Operations op = new Operations();
            op.divide(input1);

            //method with output parameters 
            Console.WriteLine("Please log another number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            OutputParameter OP = new OutputParameter();
            OP.output(input2, out int value);
            Console.WriteLine(input2 + "/4= " + value);

            //Overloading a method 
            
            Overloading overload = new Overloading();
            Console.WriteLine("Overloaded Method Int: The sum of two int digits is: {0}", overload.sum(3));
            Console.WriteLine("Overloaded Method Decimal: The sum of two decimal digits is: {0}", overload.sum(4.5M));

            //Static method 
            Console.WriteLine("Static Method: Please log another integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Static Method: Please log another integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int result = Static.Add(x, y);
            Console.WriteLine("Static Method: {0} + {1} = {2}", x, y, result);


        }
    }
}
