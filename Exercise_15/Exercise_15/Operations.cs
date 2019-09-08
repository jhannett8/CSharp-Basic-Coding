using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_15
{
    class Operations
    {
        public int operation(int number1)
        {
            int numb = number1 + 2;
            return numb;
            
        }
        public decimal operation(decimal number2)
        {
            decimal numb = number2 + 2.5M;
            return numb;
        }
        public int operation(string number3)
        {
            int numb = Convert.ToInt32(number3);
            int value = numb + 2;
            return value;
        }
    }
}
