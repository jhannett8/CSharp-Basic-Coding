using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_20
{

    public class Employee : Person, IQuittable
    {

        public override void AddPerson(string Name)
        {
            PersonList.Add(Name);
        }
        public override void DeletePerson(string Name)
        {
            PersonList.Remove(Name);
        }
        public void IQuit(string Employee)
        {
            PersonList.Remove(Name);
        }
        

    }
}
