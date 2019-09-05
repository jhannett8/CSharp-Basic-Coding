using System;
using System.Collections.Generic;

namespace Exercise_10
{
    class Program
    {
        static void Main()
        {
            //-------------Array of Numbers---------------//

            int[] numArray = { 1, 2, 4, 8, 16, 32, 64 };
            bool Input = true;
            while (Input)
            {
                Console.Write("Enter an index for Number Array: ");
                int Num_input = Convert.ToInt32(Console.ReadLine());
                if (Num_input < numArray.Length)

                {
                    Console.WriteLine("value assigned to this " + Num_input + " index is: " + numArray[Num_input]);
                    Console.WriteLine("Y/N: Would you like to enter another index number?");
                    string answer = Console.ReadLine();
                    if (answer == "N")
                    {
                        Input = false;
                        Console.WriteLine("Come back soon!");
                    }
                    else
                        Input = true;

                }
                else
                    Console.WriteLine("We're sorry, " + Num_input + " is nt a valid number. Please try again. ");



                //-------------String Section------------------------//

                //Array Of Strings//


                string[] stringArray = { "Hello", "From", "A", "Student", "In", "The", "Tech", "Academy" };
                bool s_Input = true;
                while (s_Input)
                {
                    Console.Write("Enter an index for String Array: ");
                    int string_input = Convert.ToInt32(Console.ReadLine());
                    if (string_input < stringArray.Length)

                    {
                        Console.WriteLine("value assigned to this " + string_input + " index is: " + stringArray[string_input]);
                        Console.WriteLine("Y/N: Would you like to enter another index number?");
                        string answer = Console.ReadLine();
                        if (answer == "N")
                        {
                            s_Input = false;
                            Console.WriteLine("Come back soon!");
                        }
                        else
                            s_Input = true;

                    }
                    else
                        Console.WriteLine("We're sorry, " + string_input + " is nt a valid number. Please try again. ");


                    //List Of Strings//
                    List<string> string_list = new List<string>(new string[] { "element_1", "element_2", "element_3", "element_4" });
                    bool list_Input = true;
                    while (list_Input)
                    {
                        Console.Write("Enter an index for String List: ");
                        int list_input = Convert.ToInt32(Console.ReadLine());
                        if (list_input < string_list.Count)

                        {
                            Console.WriteLine("value assigned to this " + list_input + " index is: " + string_list[list_input]);
                            Console.WriteLine("Y/N: Would you like to enter another index number?");
                            string answer = Console.ReadLine();
                            if (answer == "N")
                            {
                                list_Input = false;
                                Console.WriteLine("Come back soon!");
                            }
                            else
                                list_Input = true;

                        }
                        else
                            Console.WriteLine("We're sorry, " + list_input + " is nt a valid number. Please try again. ");

                    }
                }
            }
        }
    }
}

