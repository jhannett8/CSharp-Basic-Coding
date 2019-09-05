using System;

namespace Exercise_7
{
    class Program
    {
        static void Main()
        {
            bool morecandy = true;
            int count = 0;

            while (morecandy)
            {
                Console.WriteLine("Yes or No: Would you like another peice of candy?");

                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    int total_candycount = count++;
                    Console.WriteLine(total_candycount);
                }
                else
                {
                    morecandy = false;
                    Console.WriteLine("Its about time...");
                }
            }
        }
    }
}
