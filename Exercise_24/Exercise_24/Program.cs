using System;

namespace Exercise_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers Number = new Numbers();
            Number.Amount = 4.3M;
            Console.WriteLine("The following decimal has been assigned to \"Number\" struct: {0}", Number.Amount);
            Console.ReadLine();
        }
    }
}
