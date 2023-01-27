using Design_Patterns.Behavioral_Patterns.Stategy.Example;
using Design_Patterns.Behavioral_Patterns.Stategy.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Stategy.Source
{
    //https://www.dofactory.com/net/strategy-design-pattern

    //The Strategy design pattern defines a family of algorithms, encapsulate each one, and
    //make them interchangeable. This pattern lets the algorithm vary independently from clients that use it.

    //This structural code demonstrates the Strategy pattern which encapsulates functionality in the
    //form of an object. This allows clients to dynamically change algorithmic strategies.
    public class StrategyDemo
    {
        public void Run()
        {
            Context context;
            // Three contexts following different strategies
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
            // Wait for user
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("-------------------------- strategy example demo--------------------------");
            Console.WriteLine();

            StrategyExampleDemo seDemo = new StrategyExampleDemo();
            seDemo.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Strategy
    //declares an interface common to all supported algorithms.Context uses this interface to call the algorithm defined by a ConcreteStrategy

    //ConcreteStrategy
    //implements the algorithm using the Strategy interface

    //Context
    //is configured with a ConcreteStrategy object
    //maintains a reference to a Strategy object
    //may define an interface that lets Strategy access its data.
}
