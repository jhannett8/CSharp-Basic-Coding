using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_17
{
    class OutputParameter
    {
        public void output(int input2, out int value)
        {
            value = input2 / 4;
        }
      
    }
}
