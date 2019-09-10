using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {

            IQuittable employee = new Employee();
            employee.IQuit("Steve Jobs");
            Console.ReadLine();
        }
    }
}
