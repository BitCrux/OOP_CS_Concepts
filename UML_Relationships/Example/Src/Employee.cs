using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Example.Src
{
    public abstract class Employee
    {
        protected string _id;
        protected double _salary;
        protected string _name;

        public void SetSalary(double salary)
        {
            _salary = salary;
        }

        public double GetSalary()
        {
            return _salary;
        }
    }
}
