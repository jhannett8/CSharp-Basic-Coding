using System;
using System.Collections.Generic;

namespace Exercise_12
{
    class Program
    {
        static void Main()
        {
            //Create a list of integers. 
            //Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by 
            //the number the user entered, and displays the result to the screen.
            List<int> Integer_List = new List<int>() { 1, 2, 4, 8, 16, 32, 64, 4096 };
            Console.WriteLine("You are given the following list: ");
            foreach (int integer in Integer_List)
            {
                Console.WriteLine(integer);
            }
            try
            {
                Console.WriteLine("Please log a number that you wish to divide each number in the list by.");
                int divisor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Calculating...");
                Console.WriteLine("Our new list after dividing each value by " + divisor + ";");
                for (var i = 0; i < Integer_List.Count; i++)
                {
                    int number = (Integer_List[i] / divisor);
                    Console.WriteLine(number);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("I'm sorry, this is the incorrect format. Please try again.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("I'm sorry, you may not choose zero as a number.  Please try again.");
                return;
            }
            finally
            {
                
            }
            Console.ReadLine();
        }
    }
}
