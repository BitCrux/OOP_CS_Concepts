using Design_Patterns.Behavioral_Patterns.Command.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Command.Source
{
    // https://www.dofactory.com/net/command-design-pattern

    // The Command design pattern encapsulates a request as an object, thereby letting you parameterize 
    // clients with different requests, queue or log requests, and support undoable operations.

    // This structural code demonstrates the Command pattern which stores requests as 
    // objects allowing clients to execute or playback the requests.
    public class CommandDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Command
    //declares an interface for executing an operation

    //ConcreteCommand
    //defines a binding between a Receiver object and an action
    //implements Execute by invoking the corresponding operation(s) on Receiver

    //Client
    //creates a ConcreteCommand object and sets its receiver

    //Invoker
    //asks the command to carry out the request

    //Receiver
    //knows how to perform the operations associated with carrying out the request.
}
