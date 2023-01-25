using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Facade.Source
{
    //https://www.dofactory.com/net/facade-design-pattern

    //The Facade design pattern provides a unified interface to a set of interfaces in a subsystem.
    //This pattern defines a higher-level interface that makes the subsystem easier to use.

    //This structural code demonstrates the Facade pattern which provides a simplified and
    //uniform interface to a large subsystem of classes.
    public class FacadeDemo
    {
        public void Run()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Facade
    //knows which subsystem classes are responsible for a request.
    //delegates client requests to appropriate subsystem objects.

    //Subsystem classes
    //implement subsystem functionality.
    //handle work assigned by the Facade object.
    //have no knowledge of the facade and keep no reference to it.
}
