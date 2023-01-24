using Design_Patterns.Structural_Patterns.Decorator.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator.Source.Models
{
    //defines an object to which additional responsibilities can be attached.
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
