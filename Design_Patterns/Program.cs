using Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source;
using Design_Patterns.Behavioral_Patterns.Command.Source;
using Design_Patterns.Behavioral_Patterns.Interpreter.Source;
using Design_Patterns.Behavioral_Patterns.Iterator.Source;
using Design_Patterns.Creational_Patterns.Abstract_Factory.Source;
using Design_Patterns.Creational_Patterns.Builder.Source;
using Design_Patterns.Creational_Patterns.Factory_Method.Source;
using Design_Patterns.Creational_Patterns.Prototype.Source;
using Design_Patterns.Creational_Patterns.Singleton.Source;
using Design_Patterns.Structural_Patterns.Bridge.Source;
using Design_Patterns.Structural_Patterns.Composite.Source;
using Design_Patterns.Structural_Patterns.Decorator.Source;
using Design_Patterns.Structural_Patterns.ObjectAdapter.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------ Creational Patterns ---------------------------------------

            //AbstractFactoryDemo afDemo = new AbstractFactoryDemo();
            //afDemo.Run();

            //BuilderDemo bDemo = new BuilderDemo();
            //bDemo.Run();

            //FactoryMethodDemo fmDemo = new FactoryMethodDemo();
            //fmDemo.Run();

            //PrototypeDemo pDemo = new PrototypeDemo();
            //pDemo.Run();

            SingletonDemo sDemo = new SingletonDemo();
            sDemo.Run();

            //------------------------------------ Structural Patterns ---------------------------------------

            //ObjectAdapterDemo oaDemo = new ObjectAdapterDemo();
            //oaDemo.Run();

            //BridgeDemo bDemo = new BridgeDemo();
            //bDemo.Run();

            //CompositeDemo cDemo = new CompositeDemo();
            //cDemo.Run();

            //DecoratorDemo dDemo = new DecoratorDemo();
            //dDemo.Run();

            //------------------------------------ Behavioral Patterns ---------------------------------------

            //ChainOfResponsibilityDemo corDemo = new ChainOfResponsibilityDemo();
            //corDemo.Run();

            //CommandDemo cDemo = new CommandDemo();
            //cDemo.Run();

            //InterpreterDemo iDemo = new InterpreterDemo();
            //iDemo.Run();

            //IteratorDemo iDemo = new IteratorDemo();
            //iDemo.Run();
        }
    }
}
