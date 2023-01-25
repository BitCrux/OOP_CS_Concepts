using Design_Patterns.Structural_Patterns.Flyweight.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source.Abstracts
{
    //declares an interface through which flyweights can receive and act on extrinsic state.
    public abstract class Flyweight
    {
        public abstract void Operation(Context extrinsicstate);
    }
}
