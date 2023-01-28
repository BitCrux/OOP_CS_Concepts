using Design_Patterns.Behavioral_Patterns.Visitor.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Source.Abstracts
{
    //declares a Visit operation for each class of ConcreteElement in the object structure.
    //The operation's name and signature identifies the class that sends the Visit request to
    //the visitor. That lets the visitor determine the concrete class of the element being visited.
    //Then the visitor can access the elements directly through its particular interface
    public abstract class Visitor
    {
        public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);
        public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
    }
}
