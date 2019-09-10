using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_22
{
    public class Employee<T> 
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public List<T> Things { get; set; } 
    }
}
