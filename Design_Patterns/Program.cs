using Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source;
using Design_Patterns.Behavioral_Patterns.Command.Source;
using Design_Patterns.Creational_Patterns.Abstract_Factory.Source;
using Design_Patterns.Creational_Patterns.Builder.Source;
using Design_Patterns.Creational_Patterns.Factory_Method.Source;
using Design_Patterns.Structural_Patterns.Bridge.Source;
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

            FactoryMethodDemo fmDemo = new FactoryMethodDemo();
            fmDemo.Run();

            //------------------------------------ Structural Patterns ---------------------------------------

            //ObjectAdapterDemo oaDemo = new ObjectAdapterDemo();
            //oaDemo.Run();

            //BridgeDemo bDemo = new BridgeDemo();
            //bDemo.Run();

            //------------------------------------ Behavioral Patterns ---------------------------------------

            //ChainOfResponsibilityDemo corDemo = new ChainOfResponsibilityDemo();
            //corDemo.Run();

            //CommandDemo cDemo = new CommandDemo();
            //cDemo.Run();
        }
    }
}
