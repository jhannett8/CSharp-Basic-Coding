using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_17
{
    class Overloading
    {
        public int sum(int input3)
        {
            int add = input3 + 2;
            return add;
        }
        public decimal sum(decimal input3)
        {
            decimal add = input3 + 2.75M;
            return add;
        }

    }
    
}
