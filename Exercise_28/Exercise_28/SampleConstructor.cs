using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_28
{
    class Employee
    {
        //Chaining Constructors 
        public Employee(string id)
            : this(id, "", "")
        {

        }

        public Employee(string id, string fName)
            : this(id, fName, "")
        {

        }

        public Employee(string id, string fName, string lName)
        {            

            string _id = id;
            string _fName = fName;
            string _lName = lName;
        }
    }
}
