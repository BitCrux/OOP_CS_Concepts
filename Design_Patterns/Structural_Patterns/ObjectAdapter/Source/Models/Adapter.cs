using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.ObjectAdapter.Source.Models
{
    // adapts the interface Adaptee to the Target interface.
    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            // Possibly do some other work
            // and then call SpecificRequest
            adaptee.SpecificRequest();
        }
    }
}
