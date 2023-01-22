using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Bridge.Source.Abstracts
{
    // defines the interface for implementation classes.This interface doesn't have to correspond exactly to 
    // Abstraction's interface; in fact the two interfaces can be quite different.Typically the Implementation 
    // interface provides only primitive operations, and Abstraction defines higher-level operations based on these primitives.
    public abstract class Implementor
    {
        public abstract void Operation();
    }
}
