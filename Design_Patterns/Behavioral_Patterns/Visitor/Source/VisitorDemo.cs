using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Behavioral_Patterns.Visitor.Example;
using Design_Patterns.Behavioral_Patterns.Visitor.Source.Models;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Source
{
    //https://www.dofactory.com/net/visitor-design-pattern

    //The Visitor design pattern represents an operation to be performed on the elements of an
    //object structure. This pattern lets you define a new operation without changing the
    //classes of the elements on which it operates.

    //This structural code demonstrates the Visitor pattern in which an object traverses an object
    //structure and performs the same operation on each node in this structure.
    //Different visitor objects define different operations.
    public class VisitorDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();

            Console.WriteLine();
            Console.WriteLine("-------------------------- template method example demo--------------------------");
            Console.WriteLine();

            VisitorExampleDemo veDemo = new VisitorExampleDemo();
            veDemo.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Visitor
    //declares a Visit operation for each class of ConcreteElement in the object structure.The operation's name and signature identifies the class that sends the Visit request to the visitor. That lets the visitor determine the concrete class of the element being visited. Then the visitor can access the elements directly through its particular interface
    
    //ConcreteVisitor
    //implements each operation declared by Visitor.Each operation implements a fragment of the algorithm defined for the corresponding class or object in the structure.ConcreteVisitor provides the context for the algorithm and stores its local state.This state often accumulates results during the traversal of the structure.
    
    //Element
    //defines an Accept operation that takes a visitor as an argument.
    
    //ConcreteElement
    //implements an Accept operation that takes a visitor as an argument
    
    //ObjectStructure
    //can enumerate its elements
    //may provide a high-level interface to allow the visitor to visit its elements
    //may either be a Composite(pattern) or a collection such as a list or a set
}
