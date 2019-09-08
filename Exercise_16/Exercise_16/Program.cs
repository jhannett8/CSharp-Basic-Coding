using System;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Required: Please log a number: ");
            int required = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optional: Please log another number: ");
            try
            {
                int optionalint = Convert.ToInt32(Console.ReadLine());
                Operations op = new Operations();
                op.operation(required, optionalint);
                Console.ReadLine();
            }
            catch
            {
                Operations op = new Operations();
                op.operation(required);
                Console.ReadLine();
            }
        }
    }
}
