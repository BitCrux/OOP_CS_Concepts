using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source.Models
{
    //not all Flyweight subclasses need to be shared. The Flyweight interface enables sharing,
    //but it doesn't enforce it. It is common for UnsharedConcreteFlyweight objects to have
    //ConcreteFlyweight objects as children at some level in the flyweight object structure
    //(as the Row and Column classes have).
    public class UnsharedConcreteFlyweight : Abstracts.Flyweight
    {
        public override void Operation(Context contextWithextrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
                contextWithextrinsicstate.ExtrinsicState);
        }
    }
}
