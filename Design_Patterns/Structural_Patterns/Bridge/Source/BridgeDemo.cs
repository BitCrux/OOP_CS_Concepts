using Design_Patterns.Structural_Patterns.Bridge.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Bridge.Source
{
    // https://www.dofactory.com/net/bridge-design-pattern

    // The Bridge design pattern decouples an abstraction from its implementation so that
    // the two can vary independently.

    // This structural code demonstrates the Bridge pattern which separates(decouples) the interface 
    // from its implementation.The implementation can evolve without changing 
    // clients which use the abstraction of the object.
    public class BridgeDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Abstraction
    //defines the abstraction's interface.
    //maintains a reference to an object of type Implementor.

    //RefinedAbstraction
    //extends the interface defined by Abstraction.

    //Implementor
    //defines the interface for implementation classes.This interface doesn't have to correspond exactly to Abstraction's
    //interface; in fact the two interfaces can be quite different.Typically the Implementation interface provides only primitive
    //operations, and Abstraction defines higher-level operations based on these primitives.

    //ConcreteImplementor
    //implements the Implementor interface and defines its concrete implementation.
}
