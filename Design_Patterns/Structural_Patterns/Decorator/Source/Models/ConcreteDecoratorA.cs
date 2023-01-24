using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator.Source.Models
{
    //adds responsibilities to the component.
    public class ConcreteDecoratorA : Abstracts.Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
