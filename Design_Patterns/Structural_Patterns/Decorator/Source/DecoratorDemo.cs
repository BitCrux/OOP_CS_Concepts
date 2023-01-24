using Design_Patterns.Structural_Patterns.Decorator.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator.Source
{
    //https://www.dofactory.com/net/decorator-design-pattern

    //The Decorator design pattern attaches additional responsibilities to an object dynamically.
    //This pattern provide a flexible alternative to subclassing for extending functionality.

    //This structural code demonstrates the Decorator pattern which dynamically adds extra functionality to an existing object.
    public class DecoratorDemo
    {
        public void Run()
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();
            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Component
    //defines the interface for objects that can have responsibilities added to them dynamically.

    //ConcreteComponent
    //defines an object to which additional responsibilities can be attached.

    //Decorator
    //maintains a reference to a Component object and defines an interface that conforms to Component's interface.

    //ConcreteDecorator
    //adds responsibilities to the component.
}
