using Design_Patterns.Behavioral_Patterns.State.Example;
using Design_Patterns.Behavioral_Patterns.State.Example2;
using Design_Patterns.Behavioral_Patterns.State.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Source
{
    //https://www.dofactory.com/net/state-design-pattern

    //The State design pattern allows an object to alter its behavior when
    //its internal state changes. The object will appear to change its class.
    public class StateDemo
    {
        public void Run()
        {
            // Setup context in a state
            var context = new Context(new ConcreteStateA());
            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            // Wait for user


            Console.WriteLine();
            Console.WriteLine("-------------------------- state phone example demo--------------------------");
            Console.WriteLine();

            StatePhoneExampleDemo speDemo = new StatePhoneExampleDemo();
            speDemo.Run();

            Console.WriteLine();
            Console.WriteLine("-------------------------- state account balance example demo--------------------------");
            Console.WriteLine();

            StateAccountBalanceExample sabeDemo = new StateAccountBalanceExample();
            sabeDemo.Run();

            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Context
    //defines the interface of interest to clients
    //maintains an instance of a ConcreteState subclass that defines the current state.

    //State
    //defines an interface for encapsulating the behavior associated with a particular state of the Context.

    //Concrete State
    //each subclass implements a behavior associated with a state of Context
}
