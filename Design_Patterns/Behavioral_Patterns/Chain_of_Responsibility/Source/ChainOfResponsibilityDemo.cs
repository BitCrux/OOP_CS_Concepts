using Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source
{
    // https://www.dofactory.com/net/chain-of-responsibility-design-pattern

    // The Chain of Responsibility design pattern avoids coupling the sender of a request to its receiver 
    // by giving more than one object a chance to handle the request.This pattern chains the receiving 
    // objects and passes the request along the chain until an object handles it.

    // This structural code demonstrates the Chain of Responsibility pattern in which several linked 
    // objects(the Chain) are offered the opportunity to respond to a request or hand it off to the object next in line.
    public class ChainOfResponsibilityDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }

    //The classes and objects participating in this pattern include:

    //Handler
    //defines an interface for handling the requests
    //(optional) implements the successor link

    //ConcreteHandler
    //handles requests it is responsible for
    //can access its successor
    //if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor

    //Client
    //initiates the request to a ConcreteHandler object on the chain
}
