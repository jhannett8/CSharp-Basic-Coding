using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_21
{
    internal class Employee : Person
    {
        
        public int ID { get; set; }

        public static bool operator ==(Employee employee_1, Employee employee_2)
        {
            if (employee_1.ID == employee_2.ID)
            {
                Console.WriteLine("{0} and {1} have the same id.", employee_1.Name, employee_2.Name);
                return true;
            }
            else
            Console.WriteLine("{0} and {1} do not have the same id.", employee_1.Name, employee_2.Name);
            { return false; }


        }
        public static bool operator !=(Employee employee_1, Employee employee_2)
        {
            if (employee_1.ID != employee_2.ID)
            {
                return true;
            }
            else
            { return false; }

        }
    }
}
