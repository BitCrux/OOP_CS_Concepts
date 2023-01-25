using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Facade.Source
{
    //implement subsystem functionality.
    //handle work assigned by the Facade object.
    //have no knowledge of the facade and keep no reference to it.
    public class SubSystem1
    {
        public void MethodOne()
        {
            Console.WriteLine(" SubSystem1 Method");
        }
    }
}
