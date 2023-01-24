using Design_Patterns.Behavioral_Patterns.Iterator.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Iterator.Source
{
    //https://www.dofactory.com/net/iterator-design-pattern

    //The Iterator design pattern provides a way to access the elements of an aggregate
    //object sequentially without exposing its underlying representation.

    //This structural code demonstrates the Iterator pattern which provides for a way to
    //traverse (iterate) over a collection of items without detailing the underlying structure of the collection.
    public class IteratorDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Iterator
    //defines an interface for accessing and traversing elements.

    //ConcreteIterator
    //implements the Iterator interface.
    //keeps track of the current position in the traversal of the aggregate.

    //Aggregate
    //defines an interface for creating an Iterator object

    //ConcreteAggregate
    //implements the Iterator creation interface to return an instance of the proper ConcreteIterator
}
