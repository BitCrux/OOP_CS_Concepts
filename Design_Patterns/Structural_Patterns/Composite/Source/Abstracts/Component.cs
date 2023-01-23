using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Composite.Source.Abstracts
{
    //declares the interface for objects in the composition.
    //implements default behavior for the interface common to all classes, as appropriate.
    //declares an interface for accessing and managing its child components.
    //(optional) defines an interface for accessing a component's parent in the recursive structure, and implements it if that's appropriate.
    public abstract class Component
    {
        protected string name;

        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}
