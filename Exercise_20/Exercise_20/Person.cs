using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_20
{
    public abstract class Person
    {
        public string Name { get; set; }
        public List<string> PersonList = new List<string> {"Steve Jobs","Tony Stark","Thomas Edison","Bruce Wayne" };

        public abstract void AddPerson(string Name);

        public abstract void DeletePerson(string Name);

        public virtual void SayName()
        {
            Console.WriteLine("Name: {0} ", Name);
        }
        public virtual void ListPersons()
        {
            foreach (string Person in PersonList)
            {
                Console.WriteLine(Person);
            }
        }

    }
}
