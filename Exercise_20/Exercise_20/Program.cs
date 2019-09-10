using System;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            string Name = "Joseph Hannett";
            employee.AddPerson(Name);
            Console.WriteLine("What is the name of the Employee you would like to enter into the system?");
            string input_Name = Console.ReadLine();
            employee.AddPerson(input_Name);
            Console.WriteLine("\nThe following is a list of employees currently in the system: ");
            employee.ListPersons();
            Console.WriteLine("\nUnfortunately, Steve Jobs decided to quit =(, and will be deleted from the system.");
            employee.Quit("Steve Jobs");
            Console.WriteLine("\nThe new employee list goes as follows: ");
            employee.ListPersons();
            Console.ReadLine();
        }
    }
}
