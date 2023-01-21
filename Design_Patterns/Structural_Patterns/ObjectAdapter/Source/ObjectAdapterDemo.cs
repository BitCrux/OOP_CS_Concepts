using Design_Patterns.Structural_Patterns.ObjectAdapter.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.ObjectAdapter.Source
{
    // https://www.dofactory.com/net/adapter-design-pattern

    // The Adapter design pattern converts the interface of a class into another interface clients expect.
    // This design pattern lets classes work together that couldn‘t otherwise because of incompatible interfaces.

    // This structural code demonstrates the Adapter pattern which maps the interface of one class onto another 
    // so that they can work together.These incompatible classes may come from different libraries or frameworks.
    public class ObjectAdapterDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.UseTarget();
        }
    }

    //The classes and objects participating in this pattern include:

    //Target
    //defines the domain-specific interface that Client uses.

    //Adapter
    //adapts the interface Adaptee to the Target interface.

    //Adaptee
    //defines an existing interface that needs adapting.

    //Client
    //collaborates with objects conforming to the Target interface.
}
