using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Mediator.Source.Abstracts
{
    //each Colleague class knows its Mediator object
    //each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague
    public abstract class Colleague
    {
        protected Mediator mediator;
        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
