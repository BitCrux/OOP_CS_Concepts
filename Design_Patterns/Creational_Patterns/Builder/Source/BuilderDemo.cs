using Design_Patterns.Creational_Patterns.Builder.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Builder.Source
{
    // https://www.dofactory.com/net/builder-design-pattern

    // The Builder design pattern separates the construction of a complex object from its representation 
    // so that the same construction process can create different representations.

    // This structural code demonstrates demonstrates the Builder pattern in which complex objects are
    // created in a step-by-step fashion. The construction process can create different object representations
    // and provides a high level of control over the assembly of the objects.
    public class BuilderDemo
    {
        public void Run()
        {
            // Create director and builders
            Director director = new Director();
            Abstracts.Builder b1 = new ConcreteBuilder1();
            Abstracts.Builder b2 = new ConcreteBuilder2();
            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();
            // Wait for user
            Console.ReadKey();
        }
    }

    //The classes and objects participating in this pattern include:

    //Builder 
    //specifies an abstract interface for creating parts of a Product object

    //ConcreteBuilder
    //constructs and assembles parts of the product by implementing the Builder interface
    //defines and keeps track of the representation it creates
    //provides an interface for retrieving the product

    //Director
    //constructs an object using the Builder interface

    //Product
    //represents the complex object under construction.ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
    //includes classes that define the constituent parts, including interfaces for assembling the parts into the final result
}
