using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_21
{
    class Person
    {
        public string Name { get; set; }
        

        public void SayName()
        {
            Console.WriteLine("Name: {0}", Name);
        }
    }
}
