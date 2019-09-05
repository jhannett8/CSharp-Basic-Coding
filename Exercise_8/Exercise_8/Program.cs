using System;

namespace Exercise_8
{
    class Program
    {
        static void Main()
        {
            int count = 1;
            do
            {
                Console.WriteLine("value of a: {0}", count);
                count = count + 1;
            }
            while (count < 20);
            Console.ReadLine();
        }
    }
} 

