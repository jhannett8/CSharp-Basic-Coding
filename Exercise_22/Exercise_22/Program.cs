using System;
using System.Collections.Generic;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Employee<string> ListString = new Employee<string>();
                ListString.Things = new List<string>() { "Jeff Bezos", "Bill Gates", "Tony Stark", "Andrew Garfeild", "Ricky Sanchez" };

                foreach (string Thing in ListString.Things)
                {
                    Console.WriteLine(Thing);
                }

                Employee<int> ListInt = new Employee<int>();
                ListInt.Things = new List<int>() { 0, 1, 2, 3, 4 };

                foreach (int Thing in ListInt.Things)
                {
                    Console.WriteLine(Thing);
                }

                Console.ReadLine();
            }
        }
    }
}
