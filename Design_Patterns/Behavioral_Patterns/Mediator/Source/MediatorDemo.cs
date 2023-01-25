using Design_Patterns.Behavioral_Patterns.Mediator.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Mediator.Source
{
    //https://www.dofactory.com/net/mediator-design-pattern

    //The Mediator design pattern defines an object that encapsulates how a set of objects interact.
    //Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and
    //it lets you vary their interaction independently.

    //This structural code demonstrates the Mediator pattern facilitating loosely coupled communication
    //between different objects and object types. The mediator is a central hub through which all interaction must take place.
    public class MediatorDemo
    {
        public void Run()
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleague1 c1 = new ConcreteColleague1(m);
            ConcreteColleague2 c2 = new ConcreteColleague2(m);
            m.Colleague1 = c1;
            m.Colleague2 = c2;
            c1.Send("How are you?");
            c2.Send("Fine, thanks");
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Mediator
    //defines an interface for communicating with Colleague objects

    //ConcreteMediator
    //implements cooperative behavior by coordinating Colleague objects
    //knows and maintains its colleagues

    //Colleague classes
    //each Colleague class knows its Mediator object
    //each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague

}
