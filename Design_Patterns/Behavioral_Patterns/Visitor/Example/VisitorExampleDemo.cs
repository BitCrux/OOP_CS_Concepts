using Design_Patterns.Behavioral_Patterns.Visitor.Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Example
{
    //This real-world code demonstrates the Visitor pattern in which two objects
    //traverse a list of Employees and performs the same operation on each Employee.
    //The two visitor objects define different operations -- one adjusts vacation days and the other income.
    public class VisitorExampleDemo
    {
        public void Run()
        {
            // Setup employee collection
            Employees employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());
            // Employees are 'visited'
            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());
            // Wait for user
            Console.ReadKey();
        }
    }
}
