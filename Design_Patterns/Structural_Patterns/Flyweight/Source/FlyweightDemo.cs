using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Structural_Patterns.Flyweight.Source.Models;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source
{
    //https://www.dofactory.com/net/flyweight-design-pattern

    //The Flyweight design pattern uses sharing to support large numbers of
    //fine-grained objects efficiently.

    //This structural code demonstrates the Flyweight pattern in which a relatively
    //small number of objects is shared many times by different clients.
    public class FlyweightDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Flyweight
    //declares an interface through which flyweights can receive and act on extrinsic state.

    //ConcreteFlyweight
    //implements the Flyweight interface and adds storage for intrinsic state, if any.A ConcreteFlyweight object must
    //be sharable.Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.

    //UnsharedConcreteFlyweight
    //not all Flyweight subclasses need to be shared.The Flyweight interface enables sharing, but it doesn't enforce it.
    //It is common for UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children at some level
    //in the flyweight object structure (as the Row and Column classes have).

    //FlyweightFactory
    //creates and manages flyweight objects
    //ensures that flyweight are shared properly.When a client requests a flyweight, the FlyweightFactory objects
    //assets an existing instance or creates one, if none exists.

    //Client(FlyweightApp)
    //maintains a reference to flyweight(s).
    //computes or stores the extrinsic state of flyweight(s).
}
