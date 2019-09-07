using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_15
{
    class Operations
    {
        public void operation(int number1)
        {
            int numb = number1 + 2;
            Console.WriteLine("Your number, added by 2 is: ");
            Console.WriteLine(numb);
        }
        public void operation(decimal number2)
        {
            decimal numb = number2 + 2.5M;
            Console.WriteLine("Your decimal number, added by 2.5 is: ");
            Console.WriteLine(numb);
        }
        public void operation(string number3)
        {
            int numb = Convert.ToInt32(number3);
            int value = numb + 2;
            Console.WriteLine("Your string value, added by 2 is: ");
            Console.WriteLine(value);
        }
    }
}
