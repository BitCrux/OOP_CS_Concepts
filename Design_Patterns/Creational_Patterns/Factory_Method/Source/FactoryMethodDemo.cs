using Design_Patterns.Creational_Patterns.Factory_Method.Source.Abstracts;
using Design_Patterns.Creational_Patterns.Factory_Method.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method.Source
{
    // https://www.dofactory.com/net/factory-method-design-pattern

    // The Factory Method design pattern defines an interface for creating an object, but let subclasses 
    // decide which class to instantiate.This pattern lets a class defer instantiation to subclasses.

    // This structural code demonstrates the Factory method offering great flexibility in creating different 
    // objects.The Abstract class may provide a default object, but each subclass can instantiate an 
    // extended version of the object.
    class FactoryMethodDemo
    {
        public void Run()
        {
            // An array of creators
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Product
    //defines the interface of objects the factory method creates

    //ConcreteProduct
    //implements the Product interface

    //Creator
    //declares the factory method, which returns an object of type Product.Creator may also define
    //a default implementation of the factory method that returns a default ConcreteProduct object.
    //may call the factory method to create a Product object.

    //ConcreteCreator
    //overrides the factory method to return an instance of a ConcreteProduct.
}
