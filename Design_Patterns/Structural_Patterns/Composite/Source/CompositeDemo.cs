using Design_Patterns.Structural_Patterns.Composite.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Composite.Source
{
    //https://www.dofactory.com/net/composite-design-pattern

    //The Composite design pattern composes objects into tree structures to represent part-whole hierarchies.
    //This pattern lets clients treat individual objects and compositions of objects uniformly.

    //This structural code demonstrates the Composite pattern which allows the creation of a tree structure 
    //in which individual nodes are accessed uniformly whether they are leaf nodes or branch(composite) nodes.
    public class CompositeDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Component
    //declares the interface for objects in the composition.
    //implements default behavior for the interface common to all classes, as appropriate.
    //declares an interface for accessing and managing its child components.
    //(optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.

    //Leaf
    //represents leaf objects in the composition.A leaf has no children.
    //defines behavior for primitive objects in the composition.

    //Composite
    //defines behavior for components having children.
    //stores child components.
    //implements child-related operations in the Component interface.

    //Client
    //manipulates objects in the composition through the Component interface.
}
