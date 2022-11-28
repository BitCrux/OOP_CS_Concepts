using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Example.Src
{
    public class Worker : Employee
    {
        public Worker(string id, double salary, string name)
        {
            base._id = id;
            base._salary = salary;
            base._name = name;
        }
    }
}
