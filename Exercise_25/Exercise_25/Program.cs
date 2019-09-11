using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_25
{
    class Program

    {
        static void Main(string[] args)
        {

            //------------------------Entire List-------------------------------------------
            List<Employee> Employees = new List<Employee>();
            Employees.Add(new Employee { FirstName = "Joe", LastName = "Hannett", EmployeeID = 1 });
            Employees.Add(new Employee { FirstName = "Joe", LastName = "Jackson", EmployeeID = 2 });
            Employees.Add(new Employee { FirstName = "Tony", LastName = "Stark", EmployeeID = 3 });
            Employees.Add(new Employee { FirstName = "Bill", LastName = "Gates", EmployeeID = 4 });
            Employees.Add(new Employee { FirstName = "Andrew", LastName = "Garfeild", EmployeeID = 5 });
            Employees.Add(new Employee { FirstName = "F.Scott", LastName = "Fitzgerald", EmployeeID = 6 });
            Employees.Add(new Employee { FirstName = "Derek", LastName = "Jeter", EmployeeID = 7 });
            Employees.Add(new Employee { FirstName = "Eli", LastName = "Manning", EmployeeID = 8 });

            Console.WriteLine("Hear is a list of all your employees");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine(employee.FirstName);
            }


            //----------------------ForeachLoop------------------------------------------------
            List<Employee> Joes = new List<Employee>();
            Console.WriteLine("This list consists of those employees with the first name of Joe, and was created through a foreach loop.");
            foreach (Employee employee in Employees)
            {
                if (employee.FirstName == "Joe")
                    {
                    Joes.Add(employee);
                    Console.WriteLine(employee.FirstName);
                    }
            }
            
            //--------------------Lambda Functions---------------------------------------------
            List<Employee> JoeList = Employees.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("The following list has been created by Lambda functions: ");
            foreach (Employee employee in JoeList)
            {
                Console.WriteLine(employee.FirstName);
            }

            //-----------Lambda Function for Employees w/ IDs greater than 5-----------------
            List<Employee> idList = Employees.Where(x => x.EmployeeID > 5).ToList();
            Console.WriteLine("The following list has been created by Lambda functions: ");
            foreach (Employee employee in idList)
            {
                Console.WriteLine(employee.FirstName);
            }
            Console.ReadLine();
        }
    }
}
