using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source.Models
{
    //implements the Flyweight interface and adds storage for intrinsic state, if any.
    //A ConcreteFlyweight object must be sharable.Any state it stores must be intrinsic,
    //that is, it must be independent of the ConcreteFlyweight object's context.
    public class ConcreteFlyweight : Abstracts.Flyweight
    {
        private string _intrinsicState;
        public string IntrinsicState
        {
            get { return _intrinsicState; }
            set { _intrinsicState = value; }
        }
        public override void Operation(Context contextWithextrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + contextWithextrinsicstate.ExtrinsicState);
        }
    }
}
