using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory.Source.Abstracts
{
    // declares an interface for a type of product object
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}
