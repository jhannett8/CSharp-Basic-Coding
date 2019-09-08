using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_16
{
    class Operations
    {
        public int operation(int required, int optionalint = 1)
        {
            
            int value = required + optionalint;
            Console.WriteLine(required + " + " + optionalint + " = " + value);
            return value;
        }
    }
}
