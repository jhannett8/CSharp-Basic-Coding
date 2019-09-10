using System;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee();
            employee_1.Name = "Jesse O'Neil";
            employee_1.ID = 1;
            Employee employee_2 = new Employee();
            employee_2.Name = "Jay";
            employee_2.ID = 2;
            _ = employee_1 == employee_2;
            
            
        }
    }
}
