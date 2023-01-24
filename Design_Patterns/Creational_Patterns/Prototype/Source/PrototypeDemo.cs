using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Creational_Patterns.Prototype.Source.Models;

namespace Design_Patterns.Creational_Patterns.Prototype.Source
{
    //https://www.dofactory.com/net/prototype-design-pattern

    //The Prototype design pattern specifies the kind of objects to create using a prototypical
    //instance, and create new objects by copying this prototype.

    //This structural code demonstrates the Prototype pattern in which new objects are
    //created by copying pre-existing objects (prototypes) of the same class.
    public class PrototypeDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Prototype
    //declares an interface for cloning itself

    //ConcretePrototype
    //implements an operation for cloning itself

    //Client
    //creates a new object by asking a prototype to clone itself
}
