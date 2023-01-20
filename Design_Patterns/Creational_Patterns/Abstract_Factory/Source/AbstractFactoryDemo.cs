using Design_Patterns.Creational_Patterns.Abstract_Factory.Source.Abstracts;
using Design_Patterns.Creational_Patterns.Abstract_Factory.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory.Source
{
    // The Abstract Factory design pattern provides an interface for creating families of
    // related or dependent objects without specifying their concrete classes.

    // This structural code demonstrates the Abstract Factory pattern creating parallel hierarchies of objects.
    // Object creation has been abstracted and there is no need for hard-coded class names in the client code.


    // The classes and objects participating in this pattern include:

    // AbstractFactory  
    // declares an interface for operations that create abstract products

    // ConcreteFactory
    // implements the operations to create concrete product objects

    // AbstractProduct
    // declares an interface for a type of product object

    // Product
    // defines a product object to be created by the corresponding concrete factory
    // implements the AbstractProduct interface

    // Client  
    // uses interfaces declared by AbstractFactory and AbstractProduct classes
    public class AbstractFactoryDemo
    {
        public void Run()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();
            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            // Wait for user input
            Console.ReadKey();
        }
    }
}
