using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator.Source.Abstracts
{
    //defines the interface for objects that can have responsibilities added to them dynamically.
    public abstract class Component
    {
        public abstract void Operation();
    }
}
