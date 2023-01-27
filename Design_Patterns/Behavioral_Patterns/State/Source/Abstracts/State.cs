using Design_Patterns.Behavioral_Patterns.State.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Source.Abstracts
{
    //defines an interface for encapsulating the behavior associated with a particular state of the Context.
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
